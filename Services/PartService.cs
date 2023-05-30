using Contracts;
using Service.Contracts;
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
    }
}
