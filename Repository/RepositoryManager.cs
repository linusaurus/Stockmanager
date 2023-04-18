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
        private readonly Lazy<IPartRepository> _partRepository;
        private readonly Lazy<IInventoryRepository> _inventoryRepository;
        private readonly Lazy<IJobsRepository> _jobsRepository;
        //-----------------------------------------------------

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _partRepository = new Lazy<IPartRepository>(() => new PartRepository(repositoryContext));  
            _inventoryRepository = new Lazy<IInventoryRepository>(() => new InventoryRepository(repositoryContext));
            _jobsRepository = new Lazy<IJobsRepository>(() => new JobRepository(repositoryContext));
        }

        public IPartRepository PartRepository => _partRepository.Value;
        public IInventoryRepository InventoryRepository => _inventoryRepository.Value;

        public IJobsRepository JobsRepository => _jobsRepository.Value;

        // The save
        public void Save() => _repositoryContext.SaveChanges();
    }
}
