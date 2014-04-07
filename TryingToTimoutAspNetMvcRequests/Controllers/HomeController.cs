using System.Web.Mvc;

namespace TryingToTimoutAspNetMvcRequests.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}