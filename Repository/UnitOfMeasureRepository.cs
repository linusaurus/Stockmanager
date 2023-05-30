using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;

namespace Repository
{
    public class UnitOfMeasureRepository : RepositoryBase<UnitOfMeasure>, IUnitOfMeasureRepository
    {
        public UnitOfMeasureRepository(RepositoryContext repositoryContext)
            : base(repositoryContext) 
        {
            
        }


        public UnitOfMeasure GetById(int id, bool trackChanges) =>
            FindByCondition(e => e.UnitOfMeasureID == id,trackChanges).Single();
       

        public void UpdateUnit(UnitOfMeasure unit)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UnitOfMeasure> IUnitOfMeasureRepository.GetAll(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.UnitOfMeasureID).ToList();
       
    }
}
