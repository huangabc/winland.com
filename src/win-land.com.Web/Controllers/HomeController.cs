using Microsoft.AspNetCore.Mvc;

namespace win-land.com.Web.Controllers
{
    public class HomeController : comControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}