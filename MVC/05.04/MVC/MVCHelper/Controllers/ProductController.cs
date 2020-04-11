using MVCHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelper.Controllers
{
    public class ProductController : Controller
    {
        //CRUD
        NorthwindEntities db = new NorthwindEntities();
        public ViewResult Index()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        public ViewResult Detail(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.ProductID == id);
            return View(product);
        }

    }
}