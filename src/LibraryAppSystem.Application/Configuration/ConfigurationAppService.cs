using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LibraryAppSystem.Configuration.Dto;

namespace LibraryAppSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LibraryAppSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
