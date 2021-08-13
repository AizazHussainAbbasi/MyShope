using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AliFitnessAE_SP.Configuration;
using AliFitnessAE_SP.Web;

namespace AliFitnessAE_SP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AliFitnessAE_SPDbContextFactory : IDesignTimeDbContextFactory<AliFitnessAE_SPDbContext>
    {
        public AliFitnessAE_SPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AliFitnessAE_SPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AliFitnessAE_SPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AliFitnessAE_SPConsts.ConnectionStringName));

            return new AliFitnessAE_SPDbContext(builder.Options);
        }
    }
}
