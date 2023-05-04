using Abp.AspNetCore.Mvc.ViewComponents;

namespace LibraryAppSystem.Web.Views
{
    public abstract class LibraryAppSystemViewComponent : AbpViewComponent
    {
        protected LibraryAppSystemViewComponent()
        {
            LocalizationSourceName = LibraryAppSystemConsts.LocalizationSourceName;
        }
    }
}
