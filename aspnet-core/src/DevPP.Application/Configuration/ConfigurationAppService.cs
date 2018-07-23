using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DevPP.Configuration.Dto;

namespace DevPP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DevPPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
