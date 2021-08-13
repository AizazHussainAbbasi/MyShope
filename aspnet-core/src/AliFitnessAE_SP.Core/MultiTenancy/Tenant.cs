using Abp.MultiTenancy;
using AliFitnessAE_SP.Authorization.Users;

namespace AliFitnessAE_SP.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
