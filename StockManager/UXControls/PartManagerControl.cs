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
using Entities.Models;
using Repository;

namespace StockManager.UXControls
{
    public partial class PartManagerControl : System.Windows.Forms.UserControl
    {
        IRepositoryManager _repositoryManager;
        List<Part> _selectedParts = new List<Part>();
        Part _selectedPart;

        public Part SelectedPart { get => _selectedPart; set => _selectedPart = value; }

        public PartManagerControl(IRepositoryManager repositoryManager)
        {
            InitializeComponent();
            _repositoryManager = repositoryManager;
            Grids.BuildPartSearchGrid(dataGridView1);

            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                if (dv.SelectedRows.Count > 0)
                {

                    BindingManagerBase bm = BindingContext[dv.DataSource, dv.DataMember];
                    _selectedPart = (Part)bm.Current;
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

            if (txtSearch1.Text.Length > 1)
            {
                {
                    var partsList = _repositoryManager.PartRepository.Search(parms, false);
                    dataGridView1.DataSource = partsList;
                }

            }
            else { return; }


        }

        private void btnPrintLabels_Click(object sender, EventArgs e)
        {
            if (SelectedPart != null)
            {

                PartLabelDto partLabelDto = new PartLabelDto
                {
                    PartID = SelectedPart.PartID,
                    ItemDescription = SelectedPart.ItemDescription,
                    Location = SelectedPart.Location,
                    SKU = SelectedPart.SKU
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
                        BindingManagerBase? bm = dv.BindingContext?[dataGridView1.DataSource, dataGridView1.DataMember];
                        SelectedPart = (Part)bm.Current;
                    }

                }
            }

        }
    }
}
