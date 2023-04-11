using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    public class StockItem : IEquatable<StockItem>
    {
        public int PartID { get; set; }
        public string? Description { get; set; }
        public decimal InventoryAmount { get; set; }
        public string? Location { get; set; }
        public DateTime? DateStamp { get; set; } = DateTime.Now;

        public StockItem()
        {
            
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            StockItem objAsPart = obj as StockItem;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(StockItem other)
        {
            if (other == null) return false;
            return (this.PartID.Equals(other.PartID));
        }
    }
}
