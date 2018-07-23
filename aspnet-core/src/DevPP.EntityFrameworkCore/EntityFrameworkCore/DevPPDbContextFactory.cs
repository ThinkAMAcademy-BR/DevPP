using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DevPP.Configuration;
using DevPP.Web;

namespace DevPP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DevPPDbContextFactory : IDesignTimeDbContextFactory<DevPPDbContext>
    {
        public DevPPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DevPPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DevPPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DevPPConsts.ConnectionStringName));

            return new DevPPDbContext(builder.Options);
        }
    }
}
