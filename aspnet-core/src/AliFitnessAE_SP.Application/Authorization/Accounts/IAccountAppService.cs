using System.Threading.Tasks;
using Abp.Application.Services;
using AliFitnessAE_SP.Authorization.Accounts.Dto;

namespace AliFitnessAE_SP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
