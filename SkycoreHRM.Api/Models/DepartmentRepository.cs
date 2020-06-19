using SkycorHRM.DesignPattern;
using System.Collections.Generic;

namespace SkycoreHRM.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public DepartmentRepository() {}

        public IEnumerable<Shared.Department> GetAllDepartments()
        {
            return DataLazySingleton.Instance.GetData();
        }
    }
}
