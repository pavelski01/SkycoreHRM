using System.Collections.Generic;

namespace AdapterDemo.Model
{
    public class DepartmentRenderer
    {
        private readonly IDataDepartmentRendererAdapter _dataDepartmentRenderer;

        public DepartmentRenderer(IDataDepartmentRendererAdapter dataDepartmentRenderer)
        {
            _dataDepartmentRenderer = dataDepartmentRenderer;
        }
        public DepartmentRenderer() : this(new DataDepartmentRendererAdapter()) {}

        public string ListPatterns(IEnumerable<Department> patterns)
        {
            return _dataDepartmentRenderer.ListPatterns(patterns);
        }
    }
}