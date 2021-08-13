using System.Threading.Tasks;
using Abp.Application.Services;
using AliFitnessAE_SP.Sessions.Dto;

namespace AliFitnessAE_SP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
