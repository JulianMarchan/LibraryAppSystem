using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Entities;
using LibrarySystem.Departments.Dto;
using Abp.Domain.Entities;

namespace LibrarySystem.Departments.Dto
{
    [AutoMapFrom(typeof(DepartmentDto))]
    [AutoMapTo(typeof(Department))]
    public class CreateDepartmentDto : Entity<int>
    {
        public string Name { get; set; }
    }
}
