using MVCHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelper.Controllers
{
    public class BeginFormController : Controller
    {
        // GET: BeginForm
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id, string Name, string SurName)
        {
            Person person = new Person();
            person.ID = id;
            person.Name = Name;
            person.Surname = SurName;

            return RedirectToAction("PersonDetail",person);
        }

        public ActionResult PersonDetail(Person person)
        {

            return View(person);
        }
    }
}