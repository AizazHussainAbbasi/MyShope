using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AliFitnessAE_SP.Authorization;

namespace AliFitnessAE_SP
{
    [DependsOn(
        typeof(AliFitnessAE_SPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AliFitnessAE_SPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AliFitnessAE_SPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AliFitnessAE_SPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
