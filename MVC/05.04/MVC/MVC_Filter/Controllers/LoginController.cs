using MVC_Filter.Models.Context;
using MVC_Filter.Models.Entity;
using MVC_Filter.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Filter.Controllers
{
    public class LoginController : Controller
    {
        AppDbContext db = new AppDbContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AppUserVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = db.Users.FirstOrDefault(x => x.Password == model.Password && x.UserName == model.UserName);
                if (user != null)
                {
                    Session["login"] = user;
                    return RedirectToAction("Index", "User");

                }
                else
                {
                    TempData["error"] = "böyle bir kullanıcı bulunamadı";
                    return RedirectToAction("Hata", "Home");
                }
            }
            else
            {
            return View();
            }
           
        }
    }
}

//admin
//12