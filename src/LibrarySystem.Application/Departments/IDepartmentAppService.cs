using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;
namespace LibrarySystem.Departments
{
    public interface IDepartmentAppService : IAsyncCrudAppService<DepartmentDto, int, PagedDepartmentResultRequestDto, CreateDepartmentDto, DepartmentDto>
    {
     /*   List<Department> GetDepartments();
        Task<Department> CreateDepartments(Department input); */
    }

}
