using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCoreIdentity.Models.Entity;
using NetCoreIdentity.Models.ViewModels;

namespace NetCoreIdentity.Controllers
{
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public AppUserController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AppUserRegisterVM appUserRegisterVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = appUserRegisterVM.UserName,
                    Email = appUserRegisterVM.Email,

                };
              var result= await userManager.CreateAsync(user,appUserRegisterVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors.ToList())
                    {
                        ModelState.AddModelError(item.Code, item.Description);
                    }
                }
                return View();
            }
            else
            {
                return View();
            }

        }
    }
}