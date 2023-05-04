using Abp.Application.Services.Dto;
using Abp.MultiTenancy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.MultiTenancy.Dto
{
    public class BookDto : EntityDto<string>
    {
        public string Name { get; set; }
    }
}
