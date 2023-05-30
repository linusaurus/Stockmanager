using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Models;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUnitOfMeasureRepository
    {
        IEnumerable<UnitOfMeasure> GetAll(bool trackChanges);
        UnitOfMeasure GetById(int id,bool trackChanges);
        void UpdateUnit(UnitOfMeasure unitOfMeasure);
    }
}
