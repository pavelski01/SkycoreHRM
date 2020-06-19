using System.Collections.Generic;

namespace AdapterDemo.Model
{
    public interface IDataDepartmentRendererAdapter
    {
        string ListPatterns(IEnumerable<Department> patterns);
    }
}