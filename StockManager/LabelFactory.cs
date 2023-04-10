using Neodynamic.SDK.Printing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;





namespace StockManager
{
    public  class LabelFactory
    {
        public static void  PrintPartLabel(PartLabelDto dto)
        {

            PrinterSettings? PrinterXmlData;
            var fileName = Path.Combine(Environment.GetFolderPath(
                            Environment.SpecialFolder.ApplicationData), "GK420t.xml");
            // if the settings file doesn't exist-re-create them
            if (!File.Exists(fileName))
            {
                //Display Print Job dialog...           
                PrintJobDialog frmPrintJob = new PrintJobDialog();
                if (frmPrintJob.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(PrinterSettings));
                    using (TextWriter writer = new StreamWriter(fileName))
                    {
                        serializer.Serialize(writer, frmPrintJob.PrinterSettings);
                    }
                }
            }

            //Pull the settings from XML file --
            XmlSerializer deserializer = new XmlSerializer(typeof(PrinterSettings));
            TextReader reader = new StreamReader(fileName);
            object obj = deserializer.Deserialize(reader);
            PrinterXmlData = (PrinterSettings)obj;
            reader.Close();

            using (WindowsPrintJob pj = new WindowsPrintJob(PrinterXmlData))
            {

                //foreach (DataGridViewRow row in dgReceiptItems.SelectedRows)
                //{
                //    //OrderRecieptLineItemDto rowItem = (OrderRecieptLineItemDto)row.DataBoundItem;
                //    //if (rowItem != null)
                //    //{
                //    //    StockTagDto ts = orderReceiptRepository.GetStockTag(rowItem.OrderReceiptLineID);
                //    //    ThermalLabel tLabel = LabelEngine.GenerateLargeStockTag(ts);
                //    //    //ThermalLabel tLabel = LabelEngine.GenerateLargeStockTag(ts);

                //    //    pj.Copies = 1; // set copies
                //    //    pj.PrintOrientation = PrintOrientation.Portrait; //set orientation
                //    //    pj.ThermalLabel = tLabel;
                //    //    pj.PrintAsGraphic(tLabel);

                //    //}

                //}

            }
        }

    }
}
