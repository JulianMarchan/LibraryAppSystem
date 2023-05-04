using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryAppSystem.Authorization.Accounts.Dto;

namespace LibraryAppSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
