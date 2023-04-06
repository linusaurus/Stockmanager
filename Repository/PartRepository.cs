using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Contracts;
using Entities;


namespace Repository
{
    public class PartRepository : RepositoryBase<Part>, IPartRepository
    {
        public PartRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }
        public IEnumerable<Part> GetAllParts(bool trackchanges) =>
            FindAll(trackchanges)
                .OrderBy(c => c.PartID).ToList();

      
        public IEnumerable<Part> Search(string[] searchTerm, bool trackChanges)
        {
            IQueryable<Part>  searchParts = new List<Part>().AsQueryable();

            if (searchTerm[1].Length > 0 || !string.IsNullOrEmpty(searchTerm[1].ToString()))
            {
               searchParts = FindByCondition(c => c.ItemDescription.Contains(searchTerm[1].ToString()),false);
            }
            if (searchTerm[2].Length > 0 || !string.IsNullOrEmpty(searchTerm[2].ToString()))
            {
                searchParts = FindByCondition(c => c.ItemDescription.Contains(searchTerm[2].ToString()), false);
            }
            if (searchTerm[3].Length > 0 || !string.IsNullOrEmpty(searchTerm[3].ToString()))
            {
                searchParts = FindByCondition(c => c.ItemDescription.Contains(searchTerm[3].ToString()), false);
            }
            return searchParts.ToList();
        }

        public Part GetPartById(int id, bool trackChanges) =>
            FindByCondition(e => e.PartID == id, false).SingleOrDefault();

        public void UpdatePart(Part part)
        {
            Update(part);
            
        }
    }
}
