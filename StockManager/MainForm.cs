using Contracts;
using Motorola.Snapi;
using Motorola.Snapi.Constants.Enums;
using Motorola.Snapi.EventArguments;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entities.Models;

namespace StockManager
{
    public partial class MainForm : Form
    {

        private string _lastScanned;
        private List<String> _scannedItems = new List<string>();
        private Dictionary<int, Inventory> PulledItemsList = new Dictionary<int, Inventory>();
        private BindingSource bsItems = new BindingSource();
        private readonly IRepositoryManager _repositoryManager;
        public MainForm(IRepositoryManager repositoryManager)
        {
            InitializeComponent();
            _repositoryManager = repositoryManager;
            var hit = _repositoryManager.PartRepository.GetPartById(1, false);
            BarcodeScannerManager.Instance.Open();

            BarcodeScannerManager.Instance.RegisterForEvents(
               EventType.Barcode,
               EventType.Pnp,
               EventType.Image,
               EventType.Other,
               EventType.Rmd
               );

            if (BarcodeScannerManager.Instance.RegisteredEvents.Contains(EventType.Image))
            { };


            BarcodeScannerManager.Instance.DataReceived += OnDataReceived;
            listBox1.DataSource = bsItems;
        }


        private void OnDataReceived(object? sender, BarcodeScanEventArgs e)
        {
            _lastScanned = Regex.Replace(e.Data, "[^0-9]", "");
            txtJobnameSearch.Invoke(new Action(() => txtLastScannedResult.Text = _lastScanned));
            Invoke(new Action(() => DisplayBarcodeType(e.BarcodeType.ToString())));
            // if its our part label code
            if (e.BarcodeType == BarcodeType.Code39)
            {
                Invoke(new Action(() => LookupPartScanned(1.ToString())));
                // Invoke(new Action(() => LookupPartScanned(_lastScanned)));

            }
            // any other type of code assume its a SKU
            else if (e.BarcodeType == BarcodeType.UPCA || e.BarcodeType == BarcodeType.EAN13 || e.BarcodeType == BarcodeType.Code128)
            {
                // Invoke(new Action(() => LookupPartSKU(_lastScanned)));
                Invoke(new Action(() => LookupPartScanned(1.ToString())));
            }
        }



        private void LookupPartScanned(string partDD)
        {
            int testValue;
            if (int.TryParse(partDD, out testValue))
            {
                var foundPart = _repositoryManager.PartRepository.GetPartById(testValue, false);
                if (foundPart != null)
                {
                    if (PulledItemsList.ContainsKey(foundPart.PartID))
                    {
                        PulledItemsList[foundPart.PartID].InventoryAmount++;
                    }
                    else
                    {
                        Inventory lineItem = new Inventory();
                        lineItem.PartID = foundPart.PartID;
                        lineItem.Description = foundPart.ItemDescription;
                        lineItem.Location = foundPart.Location;
                        lineItem.InventoryAmount = 1.0m;
                        lineItem.EmpID = 8;
                        lineItem.DateStamp = DateTime.Now;
                        lineItem.TransActionType = 2;
                        // -----
                        PulledItemsList.Add(foundPart.PartID, lineItem);

                        //Push it into the list of Pick Items
                        listBox1.Invoke(new Action(() => bsItems.Add(lineItem.Description)));
                        dvgStockList.DataSource = PulledItemsList.Values.ToList();
                        dvgStockList.Refresh();

                    }



                }
            }


        }

        private void LookupPartSKU(string partScanSKU)
        {
            //var foundPart = partService.FindbySKU(_lastScanned);
            //if (foundPart != null)
            //    listBox1.Invoke(new Action(() => bsItems.Add(foundPart.ItemDescription)));
            //else
            //{

            //}
        }

        private void tsMainToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private enum ScanType
        {
            ByPartNumber,
            BySKU
        }

        private void DisplayBarcodeType(string barcodetype)
        {
            txtCodeType.Text = $"  Barcode Type is {barcodetype}";
        }


    }
}