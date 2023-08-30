using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    internal sealed class LocationService : ILocationService
    {
        private readonly IRepositoryManager _repository;

        public LocationService(IRepositoryManager repository)
        {
                _repository = repository;
                
        }

        public IEnumerable<Shared.DataTransferObjects.PartSearchList> GetLocationParts(int locationID, bool trackChanges)
        {
            try
            {
                return  _repository.PartRepository.GetPartsByLocation(locationID, false).Select(dto => new PartSearchList
                { 
                   PartID = dto.PartID,
                   ItemDescription = dto.ItemDescription,
                   AddedBy = dto.AddedBy,
                   LocationID = dto.LocationID.GetValueOrDefault(),
                   Location = dto.LocationNavigation.LocationName,               
                   DateAdded = dto.DateAdded.GetValueOrDefault().ToShortDateString(),
                   ManuPartNUm = dto.ManuPartNum,
                   UPC = dto.SKU
                
                }).ToList();
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Location> GetLocations(bool trackChanges)
        {
            return _repository.LocationRepository.GetAll(false).ToList();
        }

        public IEnumerable<RackLabelDto> GetLocationsList(bool trackChanges)
        {
            return _repository.LocationRepository.GetAll(false).Select(r => new RackLabelDto 
            { 
                Area = r.Area,
                Row = r.Row,
                Aisle = r.Aisle.ToString(),
                Bcode = r.LocationID.ToString(),
            }).ToList();
               
        }

        public RackLabelDto? GetRackLabel(int locationID, bool trackChanges)
        {
            var loc = _repository.LocationRepository.GetLocationById(locationID, trackChanges);
            RackLabelDto dto = new RackLabelDto
            {
                Aisle = loc.Aisle.ToString(),
                Area = loc.Area,
                Row = loc.Row,
                Bcode = loc.LocationID.ToString()
            };
            return dto;

        }
           
        
    }
}
