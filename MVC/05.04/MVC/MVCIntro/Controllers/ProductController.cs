﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class ProductController : Controller
    {
       public ViewResult Index()
        {
            return View();
        }
    }
}

