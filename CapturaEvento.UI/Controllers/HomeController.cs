using System.Web.Mvc;

namespace CapturaEvento.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET api/home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CapturarEventos()
        {
            return View();
        }
    }
}