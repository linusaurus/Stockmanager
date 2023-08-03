using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Contracts;
using Service;
using Service.Contracts;
using Entities.Models;
using MediatR;
using Repository;
using Shared.DataTransferObjects;
using Motorola.Snapi;
using Motorola.Snapi.EventArguments;
using Motorola.Snapi.Constants.Enums;

namespace StockManager.UXControls
{
    public partial class PartManagerControl : System.Windows.Forms.UserControl
    {
        IRepositoryManager _repositoryManager;
        IServiceManager _serviceManager;
        IMediator _mediator;
        List<Part> _selectedParts = new List<Part>();
        // PartSearchList _selectedPart;
        Part _selectedPart;

        private string _lastScanned;

        public Part SelectedPart { get => _selectedPart; set => _selectedPart = value; }


        public PartManagerControl(IRepositoryManager repositoryManager, IServiceManager serviceManager, IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            _repositoryManager = repositoryManager;
            _serviceManager = serviceManager;
            Grids.BuildPartSearchGrid(dgvPartsListing);
            dgvPartsListing.SelectionChanged += DgvPartsListing_SelectionChanged;
            dgvPartsListing.CellDoubleClick += DgvPartsListing_CellDoubleClick;

            //BarcodeScannerManager.Instance.Open();
            // BarcodeScannerManager.Instance.DataReceived += OnDataReceived;


        }

        //private void OnDataReceived(object? sender, BarcodeScanEventArgs e)
        //{
        //    /_lastScanned = e.Data;
        //    if (e.BarcodeType == BarcodeType.Code39)
        //    {
        //        var foundPart = _repositoryManager.PartRepository.GetPartById(_selectedPart.PartID, true);
        //    }

        //    //else{ foundPart.SKU = e.Data; }
        //    //_selectedPart.SKU = e.Data;
        //    //}
        //    //// Invoke(new Action(() => LookupPartSKU(e.Data.ToString())));
        //    //_repositoryManager.PartRepository.UpdatePart(foundPart);
        //}

        private void DgvPartsListing_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (_selectedPart != null)
            {
                int partID;
                int.TryParse(_selectedPart.PartID.ToString(), out partID);
                PartEditForm frm = new PartEditForm(_repositoryManager, _serviceManager, _mediator, partID);
                DataGridView dv = (DataGridView)sender;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedPart.ItemDescription = frm.Part.ItemDescription;
                    _selectedPart.ManuPartNum = frm.Part.ManuPartNum;
                    BindingManagerBase bm = BindingContext[dv.DataSource, dv.DataMember];
                    ((Part)bm.Current).ItemDescription = frm.Part.ItemDescription;
                    bm.EndCurrentEdit();
                    dv.Refresh();
                }
            };
        }

        private void DgvPartsListing_SelectionChanged(object? sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                if (dv.SelectedRows.Count > 0)
                {
                    BindingManagerBase? bm = dv.BindingContext?[dgvPartsListing.DataSource, dgvPartsListing.DataMember];
                    if (bm != null)
                    {
                        var pick = (PartSearchList)bm.Current;
                        SelectedPart = _repositoryManager.PartRepository.GetPartById(pick.PartID, false);
                    }

                    txtSelectedPart.Text = _selectedPart.ItemDescription.ToString();
                }
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))
            {
                SearchParts();
                return true;
            }
            else if (keyData == Keys.Escape) //clear the textboxes, null the dg source
            {
                txtSearch1.Text = string.Empty;
                txtSearch2.Text = string.Empty;
                txtSearch3.Text = string.Empty;
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void SearchParts()
        {
            string term0 = txtSearch1.Text;
            string term = txtSearch2.Text;
            string term2 = txtSearch3.Text;

            string[] parms = { term0, term, term2 };

            if (txtSearch1.Text.Length > 1 || txtPartID.Text.Length < 1)
            {
                {

                    var partsList = _serviceManager.PartService.Search(parms, false);
                    dgvPartsListing.DataSource = partsList.ToList();
                }

            }
            else if (txtPartID.Text.Length > 0)
            {
                int id;

                if (int.TryParse(txtPartID.Text, out id))
                {
                    PartEditForm frm = new PartEditForm(_repositoryManager, _serviceManager, _mediator, id);
                    frm.ShowDialog();
                }
            }
            else { return; }

        }

        private void btnPrintLabels_Click(object sender, EventArgs e)
        {
            if (SelectedPart != null)
            {
                var p = _repositoryManager.PartRepository.GetDeepPart(_selectedPart.PartID, true);
                var l = _repositoryManager.LocationRepository.GetLocationById(SelectedPart.LocationID.GetValueOrDefault(),false);
                
                PartLabelDto partLabelDto = new PartLabelDto
                {
                    PartID = p.PartID,
                    ItemDescription = p.ItemDescription,
                    Location = l.LocationName,
                    SKU = p.SKU
                };
                LabelFactory.PrintPartLabel(partLabelDto);
            }
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                if (dv.Rows.Count > 0)
                {
                    if (dv.SelectedRows.Count > 0)
                    {
                        BindingManagerBase? bm = dv.BindingContext?[dgvPartsListing.DataSource, dgvPartsListing.DataMember];
                        if (bm != null)
                        {
                            var pick = (PartSearchList)bm.Current;
                            SelectedPart = _repositoryManager.PartRepository.GetPartById(pick.PartID, false);

                        }
                    }

                }
            }

        }
        /// <summary>
        /// Associate a SKU with the selected part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntAssociateSKU_Click(object sender, EventArgs e)
        {
            if (_selectedPart != null)
            {
                int partID;
                int.TryParse(_selectedPart.PartID.ToString(), out partID);
                PartEditForm frm = new PartEditForm(_repositoryManager, _serviceManager, _mediator, partID);
                DataGridView dv = (DataGridView)sender;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedPart.ItemDescription = frm.Part.ItemDescription;
                    _selectedPart.ManuPartNum = frm.Part.ManuPartNum;
                    BindingManagerBase bm = BindingContext[dv.DataSource, dv.DataMember];
                    ((Part)bm.Current).ItemDescription = frm.Part.ItemDescription;
                    bm.EndCurrentEdit();
                    dv.Refresh();
                }
            }
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            txtPartID.Text = String.Empty;
        }
    }
}
