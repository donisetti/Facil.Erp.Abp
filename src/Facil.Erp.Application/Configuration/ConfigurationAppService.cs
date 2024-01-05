using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Facil.Erp.Configuration.Dto;

namespace Facil.Erp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ErpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
