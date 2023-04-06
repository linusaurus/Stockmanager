using Contracts;
using Motorola.Snapi;
using Motorola.Snapi.Constants.Enums;
using Motorola.Snapi.EventArguments;
using System.Windows.Forms;


namespace StockManager
{
    public partial class MainForm : Form
    {

        private string _lastScanned;
        private List<String> _scannedItems = new List<string>();
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
            {

            };

            BarcodeScannerManager.Instance.DataReceived += OnDataReceived;
            listBox1.DataSource = bsItems;
        }


        private void OnDataReceived(object? sender, BarcodeScanEventArgs e)
        {
            _lastScanned = e.Data;
            txtJobnameSearch.Invoke(new Action(() => txtLastScannedResult.Text = _lastScanned));
            Invoke(new Action(() => DisplayBarcodeType(e.BarcodeType.ToString())));
            // if its our part label code
            if (e.BarcodeType == BarcodeType.Code39)
            {
               // Invoke(new Action(() => LookupPartScanned(_lastScanned)));
                Invoke(new Action(() => LookupPartScanned(1.ToString())));
            }
            // any other type of code assume its a SKU
            else if (e.BarcodeType == BarcodeType.UPCA || e.BarcodeType == BarcodeType.EAN13 || e.BarcodeType == BarcodeType.Code128)
            {
               // Invoke(new Action(() => LookupPartSKU(_lastScanned)));
                Invoke(new Action(() => LookupPartScanned(1.ToString())));
            }
        }

        private void DisplayBarcodeType(string barcodetype)
        {
            txtCodeType.Text = $"  Barcode Type is {barcodetype}";
        }

        private void LookupPartScanned(string partDD)
        {
            int testValue;
            if (int.TryParse(partDD, out testValue))
            {
                var foundPart = _repositoryManager.PartRepository.GetPartById(testValue, false);
                bsItems.Add(foundPart.ItemDescription.ToString());

            }

            //Push it into the list of Pick Items
            //listBox1.Invoke(new Action(() => bsItems.Add(foundPart.ItemDescription)));
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

        private enum ScanType
        {
            ByPartNumber,
            BySKU
        }


    }
}