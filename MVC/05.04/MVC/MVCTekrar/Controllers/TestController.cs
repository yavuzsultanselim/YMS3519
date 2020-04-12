using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTekrar.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ViewResult Index()
        {
            return View();
        }
    }
}