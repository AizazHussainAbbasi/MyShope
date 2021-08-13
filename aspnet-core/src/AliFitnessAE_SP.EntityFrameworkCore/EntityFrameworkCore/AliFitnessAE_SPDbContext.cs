using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AliFitnessAE_SP.Authorization.Roles;
using AliFitnessAE_SP.Authorization.Users;
using AliFitnessAE_SP.MultiTenancy;

namespace AliFitnessAE_SP.EntityFrameworkCore
{
    public class AliFitnessAE_SPDbContext : AbpZeroDbContext<Tenant, Role, User, AliFitnessAE_SPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AliFitnessAE_SPDbContext(DbContextOptions<AliFitnessAE_SPDbContext> options)
            : base(options)
        {
        }
    }
}
