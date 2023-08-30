using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class PartService : IPartService
    {
        private readonly IRepositoryManager _repository ;
        public PartService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public Part FindFullPart(int partId, bool trackChanges)
        {
          var p = _repository.PartRepository.GetPartById(partId, trackChanges);
          return p;
            
        }
       

       

        public IEnumerable<PartSearchList> Search(string[] searchTerm, bool trackChanges)
        {
            IQueryable<Part> searchParts = new List<Part>().AsQueryable();
            searchParts.Include(m => m.Manu);
            searchParts.Include(l => l.LocationNavigation);
            searchParts.Where(r => r.PartID == 1);
            var d  = searchParts.ToList();

            var result = _repository.PartRepository.Search(searchTerm, trackChanges).Select(dto => new PartSearchList
            {
                AddedBy = dto.AddedBy,
                DateAdded = dto.DateAdded.GetValueOrDefault().ToShortDateString(),
                ItemDescription = dto.ItemDescription,
                Manufacturer = dto.Manu.Manufacturer,
                ManuPartNUm = dto.ManuPartNum,
                LocationID = dto.LocationID.GetValueOrDefault(),
 
                PartID = dto.PartID,
                UPC = dto.SKU

            }).ToList();

           


            return result;
        }
    }
}
