using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
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

        public IEnumerable<PartSearchList> Search(string[] searchTerm, bool trackChanges)
        {
            var result =  _repository.PartRepository.Search(searchTerm, trackChanges).Select(dto => new PartSearchList
            { 
                AddedBy = dto.AddedBy,
                DateAdded = dto.DateAdded.GetValueOrDefault().ToShortDateString(),
                ItemDescription = dto.ItemDescription,
                Manufacturer = dto.GetManu.Manufacturer,
                ManuPartNUm = dto.ManuPartNum,
                PartID = dto.PartID

            } ).ToList();


            return result;
        }
    }
}
