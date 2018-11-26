using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SamleTaskDemo.Configuration.Dto;

namespace SamleTaskDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SamleTaskDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
