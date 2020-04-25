using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreIntro.Models;

namespace NetCoreIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(Product.products.ToList());
        }

        public IActionResult GetProduct(int productId)//5
        {
            return View(Product.products.FirstOrDefault(x => x.ID == productId));
        }

        public IActionResult GetProductsWithCategory(int categoryId)//3
        {
            return View(Product.products.Where(x => x.CategoryId == categoryId).ToList());
        }
    }
}