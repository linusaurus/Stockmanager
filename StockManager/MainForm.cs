using Contracts;
using Motorola.Snapi;
using Motorola.Snapi.Constants.Enums;
using Motorola.Snapi.EventArguments;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entities.Models;
using Microsoft.Data.SqlClient.Server;
using System.ComponentModel;
using System.Data.Common;
using StockManager.UXControls;

namespace StockManager
{
    public partial class MainForm : Form
    {

        private string _lastScanned;

        private IList<StockItem> _scannedItems = new List<StockItem>();
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
            PartManagerControl ctr = new PartManagerControl(repositoryManager);
            ctr.Dock = DockStyle.Fill;
            tbPartManager.Controls.Add(ctr);

            Grids.BuildScannedPartGrid(dvgStockList);
            bsItems.DataSource = _lastScanned;
            dvgStockList.DataSource = bsItems;
            //--Event Wiring
            bsItems.ListChanged += BsItems_ListChanged;
            //--Event Wiring

        }

        private void BsItems_ListChanged(object? sender, ListChangedEventArgs e)
        {

        }

        private void OnDataReceived(object? sender, BarcodeScanEventArgs e)
        {

            _lastScanned = Regex.Replace(e.Data, "[^0-9]", "");
            Invoke(new Action(() => DisplayBarcodeType(e.BarcodeType.ToString())));
            Invoke(new Action(() => DisplayBarcodeValue(e.Data)));
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



        private void LookupPartScanned(string partID)
        {
            int testValue;
            if (int.TryParse(partID, out testValue))
            {
                var foundPart = _repositoryManager.PartRepository.GetPartById(testValue, false);
                if (foundPart != null)
                {

                    if (bsItems.List.Contains(new StockItem { PartID = foundPart.PartID }))
                    {
                        int index = bsItems.IndexOf(new StockItem { PartID = foundPart.PartID });
                        ((StockItem)bsItems[index]).InventoryAmount++;
                    }
                    else
                    {
                        StockItem lineItem = new StockItem();
                        lineItem.PartID = foundPart.PartID;
                        lineItem.Description = foundPart.ItemDescription;
                        lineItem.Location = foundPart.Location;
                        lineItem.InventoryAmount = 1.0m;
                        lineItem.DateStamp = DateTime.Now;

                        bsItems.Add(lineItem);


                    }
                    dvgStockList.Refresh();

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
        private void DisplayBarcodeValue(string barcodevalue)
        {
            txtLastScannedResult.Text = barcodevalue;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tabControlApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabname = tabControlApp.SelectedTab.Name;
            switch (tabname)
            {
                case "tbPartManager":

                    txtCodeType.Visible = false;
                    txtLastScannedResult.Visible = false;
                    tsbNewStockList.Visible = false;
                    tsbCloseList.Visible = false;

                    break;
                case "tbStockList":
                    txtLastScannedResult.Visible = true;
                    txtCodeType.Visible = true;
                    tsbNewStockList.Visible = true;
                    tsbCloseList.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}