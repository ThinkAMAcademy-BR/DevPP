using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DevPP.Authorization.Roles;
using DevPP.Authorization.Users;
using DevPP.MultiTenancy;

namespace DevPP.EntityFrameworkCore
{
    public class DevPPDbContext : AbpZeroDbContext<Tenant, Role, User, DevPPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DevPPDbContext(DbContextOptions<DevPPDbContext> options)
            : base(options)
        {
        }
    }
}
