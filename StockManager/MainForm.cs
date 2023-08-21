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
using System.Reflection;

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


        public MainForm(IRepositoryManager repositoryManager, IServiceManager serviceManager, IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            _serviceManager = serviceManager;
            ThermalLabel.LicenseOwner = "Richard Young-Ultimate Edition-Developer License";
            ThermalLabel.LicenseKey = "RALJ9V89HNTFJMHZWRMH6MFP82AXAXDTX3ZXUESKXRFLXAZ346GQ";
            _repositoryManager = repositoryManager;


            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "Stock-Manager " + version;



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

            PartManagerControl ctr = new PartManagerControl(repositoryManager, _serviceManager, mediator);
            ctr.Dock = DockStyle.Fill;
            ctr.Parent = this;
            tbPartManager.Controls.Add(ctr);

            LocationsManager loc = new LocationsManager(repositoryManager, _serviceManager, mediator);  
            loc.Dock = DockStyle.Fill;
            loc.Parent = this;
            tabLocations.Controls.Add(loc);


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
                    //The list is active and can be processed --
                    if (value == true)
                    {
                        tsbProccessList.Enabled = value;
                        dvgStockList.Visible = value;
                        tsbProccessList.BackColor = System.Drawing.Color.SlateBlue;
                        tsbProccessList.ForeColor = System.Drawing.Color.White;
                        tsbNewStockList.Text = "Cancel";
                        tsbNewStockList.BackColor = System.Drawing.Color.Blue;
                        tsbNewStockList.ForeColor = System.Drawing.Color.Yellow;
                        //*---------ACTIVE-------------*
                        _listIsActive = value;
                    }
                    //The list is Canceled and restarted --
                    else if (value == false)
                    {
                        bsItems.Clear();
                        tsbProccessList.BackColor = System.Drawing.Color.Gray;
                        tsbProccessList.ForeColor = System.Drawing.Color.WhiteSmoke;
                        tsbNewStockList.Text = "New List";
                        tsbNewStockList.BackColor = System.Drawing.Color.Black;
                        tsbNewStockList.ForeColor = System.Drawing.Color.White;
                        dvgStockList.Visible = value;
                        //*--------INACTIVE-----------*
                        _listIsActive = value;
                    }

                }


            }

        }

        //Process the list and reduce inventory stock
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
                //tsbProccessList.BackColor = System.Drawing.Color.Tan;
                tslStatusLabel.Text = $"Items = {bsItems.List.Count.ToString()}";

            }
        }

        private void OnDataReceived(object? sender, BarcodeScanEventArgs e)
        {
            _mediator.Send(new Ping());

            _lastScanned = e.Data;
            Invoke(new Action(() => DisplayBarcodeType(e.BarcodeType.ToString())));
            Invoke(new Action(() => DisplayBarcodeValue(e.Data)));
            // if its our part label code
            if (e.BarcodeType == BarcodeType.Code39)
            {
                if (e.Data.Length < 10)
                {
                    if (e.Data.StartsWith('J'))
                    {

                    }
                    // remove any no numeric characters ---
                    string s = Regex.Replace(e.Data, "[^0-9.]", "");
                    // return our part number
                    Invoke(new Action(() => LookupPartScanned(s)));
                }


            }
            // any other type of code assume its a SKU
            // else if (e.BarcodeType == BarcodeType.UPCA || e.BarcodeType == BarcodeType.EAN13 || e.BarcodeType == BarcodeType.Code128)
            // any kind of symbiology other than CODE 39
            if (e.Data.Length > 1)
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
                var foundPart = _repositoryManager.PartRepository.GetPartById(testValue, true);
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
                        //lineItem.Location = foundPart.LocationNavigation.LocationName;
                        lineItem.InventoryAmount = 1.0m;
                        lineItem.DateStamp = DateTime.Now;

                        bsItems.Add(lineItem);
                    }
                    dvgStockList.Refresh();

                }else
                {
                    Inventory foundJobPart = _repositoryManager.InventoryRepository.GetInventory(testValue,false);
                    StockItem lineItem = new StockItem();
                    lineItem.PartID = foundJobPart.PartID.GetValueOrDefault();
                    lineItem.Description = foundJobPart.Description;
                    lineItem.Location = foundJobPart.Location;
                    lineItem.InventoryAmount = 1.0m;
                    lineItem.DateStamp = DateTime.Now;

                    bsItems.Add(lineItem);

                }
            }

        }

        private void LookupPartSKU(string partScanSKU)
        {
            var foundPart = _repositoryManager.PartRepository.GetPartBySKU(partScanSKU, false);
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
                    lineItem.SKU = foundPart.SKU.ToString();
                    lineItem.Description = foundPart.ItemDescription;
                    // lineItem.Location = foundPart.LocationNavigation.LocationName;
                    lineItem.InventoryAmount = 1.0m;
                    lineItem.DateStamp = DateTime.Now;
                    bsItems.Add(lineItem);
                }
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

                        if (!ListIsActive)
                        { ListIsActive = true; }
                        else
                        {
                            ListIsActive = false;
                        }

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