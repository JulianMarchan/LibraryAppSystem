﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using AutoMapper;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;
using LibrarySystem.MultiTenancy.Dto;
using LibrarySystem.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarySystem.Departments
{
    public class DepartmentAppService : AsyncCrudAppService<Department, DepartmentDto, int, PagedDepartmentResultRequestDto, CreateDepartmentDto, DepartmentDto>, IDepartmentAppService
    {
        public DepartmentAppService(IRepository<Department, int> repository) : base(repository)
        {

        }

        public override Task<DepartmentDto> CreateAsync(CreateDepartmentDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task <PagedResultDto<DepartmentDto>> GetAllAsync(PagedDepartmentResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<DepartmentDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<DepartmentDto> UpdateAsync(DepartmentDto input)
        {
            return base.UpdateAsync(input);
        }
    }

}
