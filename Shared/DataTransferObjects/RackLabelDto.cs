using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class RackLabelDto
    {
        public string Area { get; set; }
        public string? Aisle { get; set; }
        public string? Row { get; set; }
        public string? Bcode { get; set; }


    }
}
