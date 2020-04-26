using Microsoft.AspNetCore.Mvc;

namespace VsCode
{
    public class HomeController:Controller
    {
            public IActionResult Index()
            {
                return View();
            }
    }
}