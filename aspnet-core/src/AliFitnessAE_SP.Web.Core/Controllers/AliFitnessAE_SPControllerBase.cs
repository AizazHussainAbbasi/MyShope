using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AliFitnessAE_SP.Controllers
{
    public abstract class AliFitnessAE_SPControllerBase: AbpController
    {
        protected AliFitnessAE_SPControllerBase()
        {
            LocalizationSourceName = AliFitnessAE_SPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
