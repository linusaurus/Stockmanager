﻿using System;
using Contracts;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        public LocationRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            
        }
        public IEnumerable<Location> GetAll(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.Area).ToList();

        public IEnumerable<Part> GetPartsbyLocation(int partID, bool trackChanges)
        {
            throw new NotImplementedException();
            
        }
          
       

        public IEnumerable<Location> Search(string[] searchTerm, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
