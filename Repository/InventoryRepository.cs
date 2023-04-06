using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class InventoryRepository : RepositoryBase<Inventory>, IInventoryRepository
    {

        public InventoryRepository(RepositoryContext repositoryContext)
            :base (repositoryContext)
        {
            
        }

        public IEnumerable<Inventory> GetAllInventory(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.StockTransactionID).ToList();
     
        public Inventory GetInventory(int stockTransactionID, bool trackChanges) =>
            FindByCondition(e => e.StockTransactionID==stockTransactionID,trackChanges).First();

       

        public IEnumerable<Inventory> GetPartTransactions(int partID, bool trackChanges) =>
          
            FindByCondition(e => e.PartID == partID, false).ToList();

        public decimal PartStockLevel(int partID) =>
            FindByCondition(e => e.PartID == partID, false).Sum(s => s.InventoryAmount.GetValueOrDefault());


        public IEnumerable<Inventory> Search(string[] searchTerm, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventory(Inventory inventory) =>
            Update(inventory);
      
    }
}
