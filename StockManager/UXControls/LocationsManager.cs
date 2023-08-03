using Contracts;
using MediatR;
using Service.Contracts;
using Shared;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.UXControls
{
    public partial class LocationsManager : UserControl
    {

        IRepositoryManager _repositoryManager;
        IServiceManager _serviceManager;
        IMediator _mediator;

        public LocationsManager(IRepositoryManager repositoryManager, IServiceManager serviceManager, IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            _repositoryManager = repositoryManager;
            _serviceManager = serviceManager;
            Grids.BuildLocationGrid(dgvLocations);
            dgvLocations.SelectionChanged += DgvLocations_SelectionChanged;
            dgvPartsByLocation.SelectionChanged += DgvPartsByLocation_SelectionChanged;
            dgvPartsByLocation.MouseDoubleClick += DgvPartsByLocation_MouseDoubleClick;
            this.dgvLocations.DataSource = _serviceManager.LocationService.GetLocationsList(false);
        }

        private void DgvPartsByLocation_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            
        }

        private void DgvLocations_SelectionChanged(object? sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null || dgv.Rows.Count > 0)
            {
                BindingManagerBase bm = dgvLocations.BindingContext[dgvLocations.DataSource, dgvLocations.DataMember];
                RackLabelDto l = (RackLabelDto)bm.Current;
                tsSelectedLocation.Text = $"Location : {l.Area?.TrimEnd()} - {l.Aisle?.TrimEnd()} - {l.Row?.TrimEnd()}";
                dgvPartsByLocation.DataSource = _serviceManager.LocationService.GetLocationParts(int.Parse(l.Bcode), false);
            }


        }

        private void DgvPartsByLocation_SelectionChanged(object? sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem?.Name)
            {
                case "tsPrintLabel":
                    var result = _serviceManager?.LocationService.GetRackLabel(12, false);
                    if (result != null) { LabelFactory.PrintRackLabel(result); }
                    break;

            }

        }
    }
}
