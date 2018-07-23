using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DevPP.EntityFrameworkCore
{
    public static class DevPPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DevPPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DevPPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
