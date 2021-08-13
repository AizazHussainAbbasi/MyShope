using System.Threading.Tasks;
using AliFitnessAE_SP.Configuration.Dto;

namespace AliFitnessAE_SP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
