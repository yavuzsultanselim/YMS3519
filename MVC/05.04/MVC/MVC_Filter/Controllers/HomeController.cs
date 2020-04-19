using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Filter.Filters;

namespace MVC_Filter.Controllers
{
    public class HomeController : Controller
    {
        [AcFilter]
        public ActionResult Index()
        {//action başlangıcı
            return View();
            //action bitişi
        }
        [ExFilter]
        public ActionResult Hata()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}