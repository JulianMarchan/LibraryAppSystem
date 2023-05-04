using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryAppSystem.Sessions.Dto;

namespace LibraryAppSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
