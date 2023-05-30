using Contracts;
using Service;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
       private readonly Lazy<ILocationService> _locationService;
       private readonly Lazy<IPartService>    _partService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _locationService = new Lazy<ILocationService>(() => new LocationService(repositoryManager));
            _partService = new Lazy<IPartService>(() => new PartService(repositoryManager));
        }

        public ILocationService LocationService => _locationService.Value; 
        public IPartService PartService => _partService.Value;
    }
}
