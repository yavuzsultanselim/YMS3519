using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTekrar.Models;

namespace MVCTekrar.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            List<Category> categories = new List<Category>()
            {
                new Category{ID=1,CategoryName="Yiyecek"},
                new Category{ID=2,CategoryName="İçecek"},
                new Category{ID=3,CategoryName="Giyim"}

            };
            return View(categories);
        }

        [HttpPost]
        public ViewResult Index(string kategoriAdi)
        {
            //burada kategoriAdi yakalandıktan sonra istediğimiz işlemleri gerçekleştirebiliriz.
            return View();
        }


    }
}