using SkycoreHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkycoreHRM.Server.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
