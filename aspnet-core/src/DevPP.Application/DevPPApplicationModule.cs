using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DevPP.Authorization;

namespace DevPP
{
    [DependsOn(
        typeof(DevPPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DevPPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DevPPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DevPPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
