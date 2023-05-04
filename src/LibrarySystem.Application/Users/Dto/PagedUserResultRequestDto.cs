using Abp.Application.Services.Dto;
using System;

namespace LibrarySystem.Users.Dto
{
    //custom PagedResultRequestDto
    public class PagedDepartmentResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
