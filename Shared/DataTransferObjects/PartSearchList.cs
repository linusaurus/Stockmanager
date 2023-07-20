using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class PartSearchList 
    {
        

        public int PartID { get; set; }
        public string? ItemDescription { get; set; }
        public string? ManuPartNUm { get; set; }
        public string? Manufacturer { get; set; }  
        public string? DateAdded { get; set; } 
        public string? AddedBy { get; set; } 


       
    }
}
