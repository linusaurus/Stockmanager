using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        // Here the bones for all the repositories
        private readonly RepositoryContext _repositoryContext;
        private readonly IPartRepository _partRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IJobsRepository _jobsRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
     
        //-----------------------------------------------------

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _partRepository  = new PartRepository(repositoryContext);  
            _inventoryRepository = new InventoryRepository(repositoryContext);
            _jobsRepository =  new JobRepository(repositoryContext);
            _locationRepository =  new LocationRepository(repositoryContext);
            _unitOfMeasureRepository =  new UnitOfMeasureRepository(repositoryContext);
        }

        public IPartRepository PartRepository => _partRepository;
        public IInventoryRepository InventoryRepository => _inventoryRepository;
        public IJobsRepository JobsRepository => _jobsRepository;
        public ILocationRepository LocationRepository => _locationRepository;

        public IUnitOfMeasureRepository UnitOfMeasureRepository => _unitOfMeasureRepository;

        // The save
        public void Save() => _repositoryContext.SaveChanges();
    }
}
