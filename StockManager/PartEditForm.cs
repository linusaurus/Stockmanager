using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contracts;
using MediatR;
using Repository;
using Entities.Models;
using Service.Contracts;

namespace StockManager
{
    public partial class PartEditForm : Form
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IServiceManager _serviceManager;
        private readonly IMediator _mediator;
        private BindingSource _bindingSource = new BindingSource();
        private Part _part;

        public PartEditForm(IRepositoryManager repositoryManager, IServiceManager serviceManager, IMediator mediator, int partID)
        {
            InitializeComponent();
            _serviceManager = serviceManager;
            _repositoryManager = repositoryManager;
            _mediator = mediator;
            _part = _repositoryManager.PartRepository.GetPartById(partID, true);
            if (_part != null || String.IsNullOrEmpty(_part.ItemDescription))
            {
                if (_part.ItemDescription != null && _part.ItemDescription.ToString().Length > 50)
                {
                    this.Text = $"Part : {_part.PartID.ToString()} :: {_part.ItemDescription.ToString().Substring(1, 49) + "..."}";
                }else
                {
                    this.Text = $"Part : {_part.PartID.ToString()} :: {_part.ItemDescription}";
                }
                
            }

            _bindingSource.DataSource = _part;

            BindPart(_bindingSource);
            LoadLocations();
            LoadUnitOfMeasure();

            //-------------wire events ------------
            _bindingSource.ListChanged += _bindingSource_ListChanged;
            cboLocations.SelectedValueChanged += CboLocations_SelectedValueChanged;
           

        }

        private void CboLocations_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (cboLocations.SelectedValue != null)
            {
                ComboBox cb = (ComboBox)sender;
              // ((Part)_bindingSource.Current).LocationID = ((Location)cb.SelectedItem).LocationID;
            }

        }

        private void _bindingSource_ListChanged(object? sender, ListChangedEventArgs e)
        {         
            ButtonToogle(true);          
        }

        private void ButtonToogle(bool dirty)
        {
            if (dirty) 
            {
                btnSave.Enabled = true;
                btnSave.FlatStyle = FlatStyle.Flat;
                btnSave.BackColor = Color.BlanchedAlmond;
                btnSave.FlatAppearance.BorderColor = Color.Red;
                btnSave.FlatAppearance.BorderSize = 2;
            }
            else if (!dirty)
            {
                btnSave.Enabled = false;
                btnSave.FlatStyle = FlatStyle.Flat;
                btnSave.BackColor = Color.Gray;
                btnSave.FlatAppearance.BorderColor = Color.DarkGray;
                btnSave.FlatAppearance.BorderSize = 0;
            }
        }

        private void BindPart(BindingSource part)
        {
            txtItemDescription.DataBindings.Clear();
            txtItemDescription.DataBindings.Add("Text", _part, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPartID.DataBindings.Clear();
            txtPartID.DataBindings.Add("Text", _part, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtManuPartName.DataBindings.Clear();
            txtManuPartName.DataBindings.Add("Text", _part, "ManuPartNum", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMarkup.DataBindings.Clear();
            txtMarkup.DataBindings.Add("Text", _part, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPartName.DataBindings.Clear();
            txtPartName.DataBindings.Add("Text", _part, "PartNum", true, DataSourceUpdateMode.OnPropertyChanged);
            txtUnitCost.DataBindings.Clear();
            txtUnitCost.DataBindings.Add("Text", _part, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);
            txtWaste.DataBindings.Clear();
            txtWaste.DataBindings.Add("Text", _part, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);
            txtWeight.DataBindings.Clear();
            txtWeight.DataBindings.Add("Text", _part, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void LoadLocations()
        {
            cboLocations.Items.Clear();
            cboLocations.DataSource = _serviceManager.LocationService.GetLocations(false);
            cboLocations.DisplayMember = "LocationName";
            cboLocations.ValueMember = "LocationID";
            cboLocations.DataBindings.Add("SelectedValue", _bindingSource, "LocationID", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void LoadUnitOfMeasure()
        {
            cbxUnitsOfMeasure.Items.Clear();
            cbxUnitsOfMeasure.DataSource = _repositoryManager.UnitOfMeasureRepository.GetAll(false);
            cbxUnitsOfMeasure.DisplayMember = "UnitName";
            cbxUnitsOfMeasure.ValueMember = "UnitOfMeasureID";
            cbxUnitsOfMeasure.DataBindings.Add("SelectedValue", _bindingSource, "UnitOfMeasureID",true,DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //_repositoryManager.PartRepository.UpdatePart(_part);
            _repositoryManager.Save();
            ButtonToogle(false);
            this.Close();
        }
    }
}

