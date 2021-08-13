using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AliFitnessAE_SP.EntityFrameworkCore
{
    public static class AliFitnessAE_SPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AliFitnessAE_SPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AliFitnessAE_SPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
