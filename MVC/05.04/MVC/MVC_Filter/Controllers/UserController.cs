using MVC_Filter.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Filter.Controllers
{
    public class UserController : Controller
    {
        [AuthFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}