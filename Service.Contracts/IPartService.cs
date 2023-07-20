using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects;


namespace Service.Contracts
{
    public interface IPartService
    {
        IEnumerable<PartSearchList> Search(string[] searchTerm,bool trackChanges);
    }
}
