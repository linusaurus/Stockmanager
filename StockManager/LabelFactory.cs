using Neodynamic.SDK.Printing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;






namespace StockManager
{
    public  class LabelFactory
    {
        public static void  PrintPartLabel(PartLabelDto dto)
        {
            string PrinterName = StockManager.Properties.Settings.Default.PrinterName;
            PrinterSettings? PrinterXmlData;
            var fileName = Path.Combine(Environment.GetFolderPath(
                            Environment.SpecialFolder.ApplicationData), PrinterName);
            if(String.IsNullOrEmpty(PrinterName))
            {
                PrinterName = "Default";
            }
            // if the settings file doesn't exist-re-create them
            if (!File.Exists(fileName))
            {
                //Display Print Job dialog...           
                PrintJobDialog frmPrintJob = new PrintJobDialog();
                if (frmPrintJob.ShowDialog() == DialogResult.OK)
                {
                    ;
                    XmlSerializer serializer = new XmlSerializer(typeof(PrinterSettings));
                    using (TextWriter writer = new StreamWriter(frmPrintJob.PrinterSettings.PrinterName))
                    {
                        serializer.Serialize(writer, frmPrintJob.PrinterSettings);
                    }
                 }
            }

            //Pull the settings from XML file --
            XmlSerializer deserializer = new XmlSerializer(typeof(PrinterSettings));
            TextReader reader = new StreamReader(Path.Combine(fileName,PrinterName));
            object obj = deserializer.Deserialize(reader);
            PrinterXmlData = (PrinterSettings)obj;
            reader.Close();

            using (WindowsPrintJob pj = new WindowsPrintJob(PrinterXmlData))
            {

                string xmlData = "";

                XmlSerializer serializer = new XmlSerializer(typeof(PartLabelDto));

                ThermalLabel tLabel = new ThermalLabel();
                tLabel.LoadXmlTemplate(System.IO.File.ReadAllText("PartLabel.tl"));
                using (var sw = new Utf8StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create(sw))
                    {
                        serializer.Serialize(writer, dto);
                        xmlData = sw.ToString();
                    }
                }
                StringReader xmlSR = new StringReader(xmlData);
                var ds = new DataSet();
                ds.ReadXml(xmlSR);
                tLabel.DataSource = ds;

                pj.ThermalLabel = tLabel;
                pj.PrintAsGraphic();
                //pj.Print();

            }
        }

        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }

    }
}
