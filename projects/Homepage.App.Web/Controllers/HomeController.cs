using System.Web.Mvc;

namespace Homepage.App.Web
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new HomeModel());
        }
    }
}