using System;
using System.Collections.Generic;
using System.Text;

namespace StockManager
{
    public class PartSearchDto 
    {
        public int PartID { get; set; }
        public string? Description { get; set; }
              
        public string? ManuName { get; set; }

        public string? PartNumber { get; set; }

        public DateTime DateAdded { get; set; }

        public string? AddedBy { get; set; }

  
    
    }
}
