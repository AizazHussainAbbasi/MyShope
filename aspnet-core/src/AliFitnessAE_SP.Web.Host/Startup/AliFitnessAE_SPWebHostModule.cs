using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AliFitnessAE_SP.Configuration;

namespace AliFitnessAE_SP.Web.Host.Startup
{
    [DependsOn(
       typeof(AliFitnessAE_SPWebCoreModule))]
    public class AliFitnessAE_SPWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AliFitnessAE_SPWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AliFitnessAE_SPWebHostModule).GetAssembly());
        }
    }
}
