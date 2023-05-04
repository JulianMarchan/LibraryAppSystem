using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LibraryAppSystem.Web.Views
{
    public abstract class LibraryAppSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LibraryAppSystemRazorPage()
        {
            LocalizationSourceName = LibraryAppSystemConsts.LocalizationSourceName;
        }
    }
}
