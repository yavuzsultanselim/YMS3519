using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreIntro.Models;

namespace NetCoreIntro.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(Users.users.ToList());
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(Users users)
        {
            Users.users.Add(users);
            return RedirectToAction("Index");
        }

        public IActionResult TagHelper()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TagHelper(Users users)
        {
            Users.users.Add(users);
            return RedirectToAction("Index");
        }
    }
}