using SkycoreHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkycoreHRM.Server.Services
{
    public interface IDepartmentDataService
    {
        Task<IEnumerable<Department>> GetAllDepartments();
    }
}
