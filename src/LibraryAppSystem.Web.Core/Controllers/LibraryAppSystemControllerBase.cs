using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LibraryAppSystem.Controllers
{
    public abstract class LibraryAppSystemControllerBase: AbpController
    {
        protected LibraryAppSystemControllerBase()
        {
            LocalizationSourceName = LibraryAppSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
