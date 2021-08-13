using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using AliFitnessAE_SP.Authorization;
using AliFitnessAE_SP.Authorization.Roles;
using AliFitnessAE_SP.Authorization.Users;
using AliFitnessAE_SP.Editions;
using AliFitnessAE_SP.MultiTenancy;

namespace AliFitnessAE_SP.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
