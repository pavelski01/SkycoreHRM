using Microsoft.AspNetCore.Components;
using SkycoreHRM.Server.Services;
using SkycoreHRM.Shared;
using System.Threading.Tasks;

namespace SkycoreHRM.Server.Pages
{
	public class EmployeeDetailBase : ComponentBase
    {
		[Parameter]
		public string EmployeeId { get; set; }
		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }
		public Employee Employee { get; set; } = new Employee();
		protected override async Task OnInitializedAsync()
		{
			Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
		}			
	}
}
