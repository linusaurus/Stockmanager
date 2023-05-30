using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Repository;
using System.Windows.Forms;
using Contracts;

namespace StockManager
{
    public partial class PartEditor : UserControl
    {
        Part _editPart;
        IRepositoryManager _repositoryManager;
        public PartEditor(IRepositoryManager repositoryManager)
        {
            InitializeComponent();
            _repositoryManager = repositoryManager;
            Grids.BuildPartsTransActionsGrid(dgvPartTransactions);
        }
    }
}
