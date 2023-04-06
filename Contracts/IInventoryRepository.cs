using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IInventoryRepository
    {
        IEnumerable<Inventory> GetAllInventory(bool trackChanges);
        IEnumerable<Inventory> Search(string[] searchTerm, bool trackChanges);

        Inventory GetInventory(int stockTransactionID, bool trackChanges);

        Decimal PartStockLevel(int partID);

        IEnumerable<Inventory> GetPartTransactions(int partID, bool trackChanges);

        void Update(Inventory inventory);

    }
}
