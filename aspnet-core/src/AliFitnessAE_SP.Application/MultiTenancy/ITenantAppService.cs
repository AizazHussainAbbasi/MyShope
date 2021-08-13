using Abp.Application.Services;
using AliFitnessAE_SP.MultiTenancy.Dto;

namespace AliFitnessAE_SP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

