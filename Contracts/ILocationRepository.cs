using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contracts
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetAll(bool trackChanges);
        IEnumerable<Location> Search(string[] searchTerm, bool trackChanges);

        IEnumerable<Part> GetPartsbyLocation(int partID, bool trackChanges);

        void Update(Location location);
    }
}
