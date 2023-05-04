using Abp.Application.Services;
using LibraryAppSystem.MultiTenancy.Dto;

namespace LibraryAppSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

