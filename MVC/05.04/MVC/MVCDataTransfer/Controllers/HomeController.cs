using MVCDataTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataTransfer.Controllers
{
    public class HomeController : Controller
    {

        /*
         ViewData & ViewBag

            küçük boyutlardaki verileri Controller'dan view sayfasına taşınma işlemlerini gerçekleştirir.
            ViewData MVC 2 ile gelen bir özelliktir.
            ViewBag MVC 3 ile gelen bir özelliktir.

            TempData

            Basit bir çalışma mantığına sahiptir.
            ViewBag ve ViewData'dan ayıran en büyük özellik bir sonraki sayfaya taşınan verilerin daha sonra tekrardan başka bir sayfada kullanılmasıdır.

         */
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>()
            {
                new Category{ID=1,CategoryName="Beverages"},
                new Category{ID=2,CategoryName="Condiments"},
                new Category{ID=3,CategoryName="Confections"},
                new Category{ID=4,CategoryName="Diary Products"},

            };
            ViewData["Categories"] = categories;
            ViewBag.Categories = categories;
            TempData["Categories"] = categories;
            return View();
        }

        public ActionResult Category()
        {
            return View();
        }
    }
}