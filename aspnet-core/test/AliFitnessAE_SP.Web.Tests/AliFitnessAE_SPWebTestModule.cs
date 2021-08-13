using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AliFitnessAE_SP.EntityFrameworkCore;
using AliFitnessAE_SP.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AliFitnessAE_SP.Web.Tests
{
    [DependsOn(
        typeof(AliFitnessAE_SPWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AliFitnessAE_SPWebTestModule : AbpModule
    {
        public AliFitnessAE_SPWebTestModule(AliFitnessAE_SPEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AliFitnessAE_SPWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AliFitnessAE_SPWebMvcModule).Assembly);
        }
    }
}