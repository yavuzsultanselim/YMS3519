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
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginVM appUserLoginVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByNameAsync(appUserLoginVM.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    var result =await signInManager.PasswordSignInAsync(user, appUserLoginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                }
            }
            return View();
        }
    }
}