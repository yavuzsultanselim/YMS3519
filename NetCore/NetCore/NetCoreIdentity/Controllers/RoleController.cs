using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCoreIdentity.Models.Entity;

namespace NetCoreIdentity.Controllers
{
    public class RoleController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppUserRole> roleManager;

        public RoleController(UserManager<AppUser> userManager, RoleManager<AppUserRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View(roleManager.Roles);
        }

        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(AppUserRole appUserRole)
        {
            if (ModelState.IsValid)
            {
                var result =await roleManager.CreateAsync(appUserRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        //Kullanıcı rol tanımlama...
    }
}