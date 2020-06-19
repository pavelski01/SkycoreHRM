using Microsoft.AspNetCore.Components;
using SkycoreHRM.Server.Services;
using SkycoreHRM.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkycoreHRM.Server.Pages
{
    public class DepartmentOverviewBase : ComponentBase
    {
		[Inject]
		public IDepartmentDataService DepartmentDataService { get; set; }
		protected override async Task OnInitializedAsync()
		{
			Departments = (await DepartmentDataService.GetAllDepartments()).ToList();
		}
		public IEnumerable<Department> Departments { get; set; }
		
	}
}
