using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AliFitnessAE_SP.Configuration;
using AliFitnessAE_SP.EntityFrameworkCore;
using AliFitnessAE_SP.Migrator.DependencyInjection;

namespace AliFitnessAE_SP.Migrator
{
    [DependsOn(typeof(AliFitnessAE_SPEntityFrameworkModule))]
    public class AliFitnessAE_SPMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AliFitnessAE_SPMigratorModule(AliFitnessAE_SPEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AliFitnessAE_SPMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AliFitnessAE_SPConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AliFitnessAE_SPMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
