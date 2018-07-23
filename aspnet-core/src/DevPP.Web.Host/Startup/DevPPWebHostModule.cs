using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DevPP.Configuration;

namespace DevPP.Web.Host.Startup
{
    [DependsOn(
       typeof(DevPPWebCoreModule))]
    public class DevPPWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DevPPWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DevPPWebHostModule).GetAssembly());
        }
    }
}
