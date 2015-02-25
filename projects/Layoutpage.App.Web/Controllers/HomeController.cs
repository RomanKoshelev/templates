using System.Web.Mvc;

namespace Layoutpage.App.Web
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new HomeModel());
        }
    }
}