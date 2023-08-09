using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
            searchParts.Include(d => d.Location);
            searchParts.Include(f => f.Manu);

            var isSearchOneNullOrEmpty = string.IsNullOrEmpty(searchTerm[0]);
            var isSearchTwoNullOrEmpty = string.IsNullOrEmpty(searchTerm[1]);
            var isSearchThreeNullOrEmpty = string.IsNullOrEmpty(searchTerm[2]);

            searchParts = base.RepositoryContext.Part.Include(m => m.Manu).Where(a =>
            (isSearchOneNullOrEmpty || a.ItemDescription.Contains(searchTerm[0])
            ) &&
            (isSearchTwoNullOrEmpty || a.ItemDescription.Contains(searchTerm[1])
            ) &&
            (isSearchThreeNullOrEmpty || a.ItemDescription.Contains(searchTerm[2]))
            );

            return searchParts.ToList();
        }

        public Part GetPartById(int id, bool trackChanges) =>
            FindByCondition(e => e.PartID == id, trackChanges).Single();

        public void UpdatePart(Part part)
        {
            Update(part);          
        }
        // Look up the part using the UPC code returned by scanner
        public Part GetPartBySKU(string sku, bool trackChanges)
        {
            return FindByCondition(e => e.SKU.Contains(sku), trackChanges).FirstOrDefault();
        }

        public IEnumerable<Part> GetPartsByLocation(int locationID, bool trackChanges)
        {
            var query = FindByCondition(e => e.LocationID == locationID, trackChanges);
            query.Include(m => m.Manu).Load();
            query.Include(l => l.Location).Load();
           
            return query.ToList();
        }
            

        public Part? GetDeepPart(int id, bool trackChnages)
        {
            
            IQueryable<Part> r = FindByCondition(e => e.PartID == id, true);
            r.Include(m => m.Manu);
            r.Include(l => l.Location);


            return r.FirstOrDefault();
        }
    }
}
