using Contracts;
using Entities.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class LocationService : ILocationService
    {
        private readonly IRepositoryManager _repository;

        public LocationService(IRepositoryManager repository)
        {
                _repository = repository;
                
        }

        public IEnumerable<Part> GetLocationParts(int locationID, bool trackChanges)
        {
            try
            {
                var locationParts = _repository.PartRepository.GetPartsByLocation(locationID, false).ToList();
                return locationParts;
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
    }
}
