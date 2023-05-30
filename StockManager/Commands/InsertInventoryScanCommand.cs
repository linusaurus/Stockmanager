using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace StockManager.Commands
{
    public class InsertInventoryScanCommand : IRequest<Inventory>
    {
        public Inventory inv { get; set; }
        public InsertInventoryScanCommand(Inventory _inventory)
        {
            inv =  _inventory;
        }
    }
}
