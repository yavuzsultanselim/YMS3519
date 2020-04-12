using MVCHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelper.Controllers
{
    public class TextBoxController : Controller
    {
        // GET: TextBox
        public ActionResult Index()
        {
            Person person = new Person();
            person.ID = 1;
            person.Name = "Fatih";
            person.Surname = "Günalp";
            return View(person);
        }

        public ViewResult TextBoxFor()
        {

            return View();
        }
    }
}