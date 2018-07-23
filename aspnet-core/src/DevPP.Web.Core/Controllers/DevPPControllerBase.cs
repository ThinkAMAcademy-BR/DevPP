using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DevPP.Controllers
{
    public abstract class DevPPControllerBase: AbpController
    {
        protected DevPPControllerBase()
        {
            LocalizationSourceName = DevPPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
