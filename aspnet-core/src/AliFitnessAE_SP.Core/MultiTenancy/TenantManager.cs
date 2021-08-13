using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using AliFitnessAE_SP.Authorization.Users;
using AliFitnessAE_SP.Editions;

namespace AliFitnessAE_SP.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
