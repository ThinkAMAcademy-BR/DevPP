using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DevPP.Authorization.Roles;
using DevPP.Authorization.Users;
using DevPP.MultiTenancy;
using DevPP.Presentations;

namespace DevPP.EntityFrameworkCore
{   

    public class DevPPDbContext : AbpZeroDbContext<Tenant, Role, User, DevPPDbContext>
    {

        public virtual DbSet<Presentation> Presentations { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        
        public DevPPDbContext(DbContextOptions<DevPPDbContext> options)
            : base(options)
        {
        }
    }
}
