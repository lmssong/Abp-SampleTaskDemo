using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SamleTaskDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SamleTaskDemoControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}