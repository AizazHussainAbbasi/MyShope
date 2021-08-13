using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AliFitnessAE_SP.Configuration.Dto;

namespace AliFitnessAE_SP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AliFitnessAE_SPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
