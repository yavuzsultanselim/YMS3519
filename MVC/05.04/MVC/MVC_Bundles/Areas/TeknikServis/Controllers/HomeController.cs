using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Bundles.Areas.TeknikServis.Controllers
{
    public class HomeController : Controller
    {
        // GET: TeknikServis/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}