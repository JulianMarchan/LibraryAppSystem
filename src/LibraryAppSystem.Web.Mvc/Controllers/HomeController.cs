using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LibraryAppSystem.Controllers;

namespace LibraryAppSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LibraryAppSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
