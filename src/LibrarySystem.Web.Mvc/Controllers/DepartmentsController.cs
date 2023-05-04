using Abp.Application.Services.Dto;
using LibrarySystem.Controllers;
using LibrarySystem.Departments;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Web.Models.Departments;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Web.Controllers
{
    //Departments/
    public class DepartmentsController : LibrarySystemControllerBase
    {
        private readonly IDepartmentAppService _departmentAppService;

        public DepartmentsController(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }

        public async Task<IActionResult> Index()
        {
            var departments = await _departmentAppService.GetAllAsync(new PagedDepartmentResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new DepartmentListViewModel()
            {
                Departments = departments.Items.ToList()
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrEditDepartment(int id)
        {
            var department = await _departmentAppService.GetAsync(new EntityDto<int>(id));
            var model = new CreateOrEditDepartmentViewModel()
            {
                Id = department.Id,
                Name = department.Name,
            };

            return View(model);
        }
    }
}
