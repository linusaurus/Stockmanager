using Contracts;
using Entities.Models;
using Service;
using Service.Contracts;
using MediatR;
using Motorola.Snapi;
using Motorola.Snapi.Constants.Enums;
using Motorola.Snapi.EventArguments;
using Neodynamic.SDK.Printing;
using StockManager.UXControls;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace StockManager
{
    public partial class MainForm : Form
    {

        private string _lastScanned;
        private readonly IMediator _mediator;
        private readonly IServiceManager _serviceManager;
        private IList<StockItem> _scannedItems = new List<StockItem>();
        private Dictionary<int, Inventory> PulledItemsList = new Dictionary<int, Inventory>();
        private BindingSource bsItems = new BindingSource();
        private bool _listIsActive;
        private Job _selectedJob;
        private StockItem _selectedStockItem;
        public class Ping : IRequest<string> { }

        public class PingHandler : IRequestHandler<Ping, string>
        {
            public Task<string> Handle(Ping request, CancellationToken cancellationToken)
            {
                return System.Threading.Tasks.Task.FromResult("Pong");
            }
        }

        private readonly IRepositoryManager _repositoryManager;


        public MainForm(IRepositoryManager repositoryManager,IServiceManager serviceManager ,IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            _serviceManager = serviceManager;
            ThermalLabel.LicenseOwner = "Richard Young-Ultimate Edition-Developer License";
            ThermalLabel.LicenseKey = "RALJ9V89HNTFJMHZWRMH6MFP82AXAXDTX3ZXUESKXRFLXAZ346GQ";


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

            PartManagerControl ctr = new PartManagerControl( repositoryManager,_serviceManager, mediator);
            ctr.Dock = DockStyle.Fill;
            tbPartManager.Controls.Add(ctr);
           

            LoadJobs();

            Grids.BuildScannedPartGrid(dvgStockList);
            bsItems.DataSource = _lastScanned;
            dvgStockList.DataSource = bsItems;
            //--Event Wiring
            bsItems.ListChanged += BsItems_ListChanged;
            dvgStockList.SelectionChanged += DvgStockList_SelectionChanged;
 
            //--Event Wiring
        }

        private void Ctr_SelectedChanged(object? sender, EventArgs e)
        {
          
        }

        private void DvgStockList_SelectionChanged(object? sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;

            if (dvg.DataSource != null)
            {
                if (dvg.SelectedRows.Count > 0)
                {
                    BindingManagerBase bm = BindingContext[dvg.DataSource, dvg.DataMember];
                    _selectedStockItem = (StockItem)bm.Current;
                }
            }
        }

        public bool ListIsActive
        {
            get => _listIsActive;
            set
            {
                if (_listIsActive != value)
                {
                    if (value == true)
                    {
                        tsbNewStockList.Enabled = !value;
                        tsbProccessList.Enabled = value;
                        dvgStockList.Visible = value;
                        tsbProccessList.BackColor = System.Drawing.Color.OldLace;
                        _listIsActive = value;
                    }
                    else if (value == false)
                    {
                        tsbNewStockList.Enabled = true;
                        tsbProccessList.Enabled = false;
                        bsItems.Clear();
                        dvgStockList.Visible = value;
                        tsbProccessList.BackColor = System.Drawing.Color.White;
                        _listIsActive = value;
                    }

                }


            }

        }


        private bool ProcessItem()
        {
            bool result = false;


            List<Inventory> inventories = new List<Inventory>();
            foreach (StockItem item in bsItems.List)
            {
                var part = _repositoryManager.PartRepository.GetPartById(item.PartID, false);
                Inventory inventory = new Inventory
                {
                    PartID = item.PartID,
                    DateStamp = DateTime.Now,
                    Description = item.Description,
                    EmpID = 8,
                    JobID = _selectedJob.jobID,
                    InventoryAmount = item.InventoryAmount * -1.0m,
                    Location = part.Location,
                    TransActionType = 3,
                    UnitOfMeasureID = part.UnitOfMeasureID.GetValueOrDefault()
                };

                _repositoryManager.InventoryRepository.Update(inventory);

            }
            _repositoryManager.Save();
            ListIsActive = false;
            return result;

        }

        private void BsItems_ListChanged(object? sender, ListChangedEventArgs e)
        {
            BindingSource bs = (BindingSource)sender;
            if (bs != null || bs.List.Count > 0 || _listIsActive)
            {

                tsbProccessList.Enabled = true;
                tsbProccessList.BackColor = System.Drawing.Color.Tan;
                tslStatusLabel.Text = $"Items = {bsItems.List.Count.ToString()}";

            }
        }

        private void OnDataReceived(object? sender, BarcodeScanEventArgs e)
        {
            _mediator.Send(new Ping());
            _lastScanned = Regex.Replace(e.Data, "[^0-9]", "");
            Invoke(new Action(() => DisplayBarcodeType(e.BarcodeType.ToString())));
            Invoke(new Action(() => DisplayBarcodeValue(e.Data)));
            // if its our part label code
            if (e.BarcodeType == BarcodeType.Code39)
            {
                //Invoke(new Action(() => LookupPartScanned(1.ToString())));
                Invoke(new Action(() => LookupPartScanned(_lastScanned)));

            }
            // any other type of code assume its a SKU
            // else if (e.BarcodeType == BarcodeType.UPCA || e.BarcodeType == BarcodeType.EAN13 || e.BarcodeType == BarcodeType.Code128)
            // any kind of symbiology other than CODE 39
            else
            {
                Invoke(new Action(() => LookupPartSKU(e.Data.ToString())));
            }

        }


        #region Scanner Methods
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
                        lineItem.SKU = foundPart.SKU;
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
            var foundPart = _repositoryManager.PartRepository.GetPartBySKU(partScanSKU, false);
            if (foundPart != null)
            {
                StockItem lineItem = new StockItem();
                lineItem.PartID = foundPart.PartID;
                lineItem.SKU = foundPart.SKU.ToString();
                lineItem.Description = foundPart.ItemDescription;
                lineItem.Location = foundPart.Location;
                lineItem.InventoryAmount = 1.0m;
                lineItem.DateStamp = DateTime.Now;
                bsItems.Add(lineItem);
            }

            dvgStockList.Refresh();

        }

        #endregion

        private void tsMainToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != null)
            {

                switch (e.ClickedItem.Name)
                {
                    case "tsbNewStockList":

                        ListIsActive = true;

                        break;
                    case "tsbProccessList":

                        if (ProcessItem())
                        {
                            ListIsActive = false;
                        }
                        break;
                    default: break;

                }
            }
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
                    break;
                case "tbStockList":
                    txtLastScannedResult.Visible = true;
                    txtCodeType.Visible = true;
                    tsbNewStockList.Visible = true;
                    tsbProccessList.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void LoadJobs()
        {
            tscboJobs.Items.Clear();
            tscboJobs.ComboBox.ValueMember = "JobID";
            tscboJobs.ComboBox.DisplayMember = "JobName";
            tscboJobs.ComboBox.DataSource = _repositoryManager.JobsRepository.GetAllJobs(false, false);
        }

        private void tscboJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox cb = (ToolStripComboBox)sender;
            _selectedJob = (Job)cb.SelectedItem;
        }
    }
}