using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using AliFitnessAE_SP.EntityFrameworkCore.Seed;

namespace AliFitnessAE_SP.EntityFrameworkCore
{
    [DependsOn(
        typeof(AliFitnessAE_SPCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AliFitnessAE_SPEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AliFitnessAE_SPDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AliFitnessAE_SPDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AliFitnessAE_SPDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AliFitnessAE_SPEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
