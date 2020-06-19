using Microsoft.AspNetCore.Mvc;
using SkycoreHRM.Api.Models;

namespace SkycoreHRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(_departmentRepository.GetAllDepartments());
        }
    }
}