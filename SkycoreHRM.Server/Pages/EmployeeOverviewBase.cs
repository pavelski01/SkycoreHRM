using Microsoft.AspNetCore.Components;
using SkycoreHRM.Server.Services;
using SkycoreHRM.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkycoreHRM.Server.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }
		protected override async Task OnInitializedAsync()
		{
			Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
		}
		public IEnumerable<Employee> Employees { get; set; }
		
	}
}
