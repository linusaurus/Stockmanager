using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boxed.Mapping;
using Entities.Models;
using Shared.DataTransferObjects;

namespace Shared.Mappers
{
    public class PartListMappers : IMapper<Part, PartSearchList>
    {
        public void Map(Part source, PartSearchList destination)
        {
            destination.PartID = source.PartID;
            destination.Manufacturer = source.Manu.Manufacturer;
            destination.ManuPartNUm = source.ManuPartNum.ToString();
            destination.ItemDescription = source.ItemDescription;
            destination.AddedBy = source.AddedBy;
            destination.DateAdded = source.DateAdded.GetValueOrDefault().ToShortDateString();
            
        }

    }
}
