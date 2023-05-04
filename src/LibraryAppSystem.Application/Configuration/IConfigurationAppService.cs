using System.Threading.Tasks;
using LibraryAppSystem.Configuration.Dto;

namespace LibraryAppSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
