using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
    }
}