using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreDepencyInjection.Models.Abstract;
using NetCoreDepencyInjection.Models.Entity;
using NetCoreDepencyInjection.Models.Repository;

namespace NetCoreDepencyInjection.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            //ProductRepository productRepository = new ProductRepository();
            //return View(productRepository.Products());
            return View(_productRepository.Products());
        }
    }
}