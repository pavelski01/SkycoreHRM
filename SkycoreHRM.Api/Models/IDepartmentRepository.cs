using SkycoreHRM.Shared;
using System.Collections.Generic;

namespace SkycoreHRM.Api.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
