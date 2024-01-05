using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Facil.Erp.Controllers;

namespace Facil.Erp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ErpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
