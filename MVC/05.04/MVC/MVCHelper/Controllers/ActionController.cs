using MVCHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelper.Controllers
{
    public class ActionController : Controller
    {
        
        public ViewResult Index()
        {
            return View();
        }

        public PartialViewResult _PartialAction()
        {
            return PartialView();
        }

        public PartialViewResult _PartialActionRouteValue(int id)
        {
            List<Sehirler> sehiler = new List<Sehirler>()
            {
                new Sehirler{ ID=1,SehirAdi="İstanbul"},
                new Sehirler{ ID=2,SehirAdi="Ankara"},
                new Sehirler{ ID=3,SehirAdi="İzmir"}
            };
            Sehirler sehir = sehiler.Where(x => x.ID == id).FirstOrDefault();
            return PartialView(sehir);
        }
    }
}