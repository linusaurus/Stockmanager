using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class JobRepository : RepositoryBase<Job>, IJobsRepository
    {
        public JobRepository(RepositoryContext repositoryContext)
            : base(repositoryContext) 
        {
            
        }

        public IEnumerable<Job> GetAllJobs(bool topLevelOnly, bool trackChanges)
        {
          
            if (topLevelOnly)
            {
                
                return FindByCondition(e => e.ParentID==1,trackChanges).ToList();
            }
            else
            {
                return FindAll(trackChanges).OrderByDescending(c => c.start_ts).ToList();
            }
        }
           
        

        public Job? GetJobById(int id, bool trackChanges) =>
            FindByCondition(e => e.jobID == id, false).SingleOrDefault();


        public IEnumerable<Job> Search(string jobName, bool trackChanges)
        {
            IQueryable<Job> searchJobs = new List<Job>().AsQueryable();

            searchJobs = base.RepositoryContext.Job.Where(a =>
            a.jobname.Contains(jobName)).OrderByDescending(t => t.start_ts);
            
            return searchJobs.ToList();
        }
    }
}
