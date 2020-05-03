using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCoreIdentity.Models.Context;
using NetCoreIdentity.Models.Entity;
using NetCoreIdentity.Models.ViewModels;

namespace NetCoreIdentity.Controllers
{
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppUserRole> roleManager;

        public AppUserController(UserManager<AppUser> userManager, RoleManager<AppUserRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View(userManager.Users);
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
                var result = await userManager.CreateAsync(user, appUserRegisterVM.Password);
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

        public async Task<IActionResult> Details(string id)
        {
            var detail = await userManager.FindByIdAsync(id);
            if (detail != null)
            {
                return View(detail);
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var deletedUser = await userManager.FindByIdAsync(id);
            if (deletedUser != null)
            {
                return View(deletedUser);
            }
            return View();
        }

        //Todo: Hata veriyor. Araştırlacak.
        [HttpPost]
        public async Task<IActionResult> Delete(AppUser user)
        {

            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> AssignAdminRole(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
               await userManager.AddToRoleAsync(user, "Admin");
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}