using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public  interface IJobsRepository
    {
        IEnumerable<Job> GetAllJobs(bool topLevelOnly,bool trackChanges);
        IEnumerable<Job> Search(string jobName ,bool trackChanges);
        Job GetJobById(int id, bool trackChanges);
       
    }
}
