using MVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
    public class ShipperController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            List<Shipper> shippers = db.Shippers.ToList();
            //Eğer dilerseniz küçük boyulu verileriniz için aşağıdaki yapıları kullanarak Action'dan view'a veri taşıyabilirsiniz.
            //ViewBag
            //ViewData
            //TempData
            return View(shippers);
        }
      
        public ActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult Create(Shipper model)
        {
            db.Shippers.Add(model);
            db.SaveChanges();
            TempData["success"] = $"{model.CompanyName} başarılı bir şekilde oluşturuldu";
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)//3
        {
           Shipper shipper= db.Shippers.Find(id);
            return View(shipper);
        }
        [HttpPost]
        public ActionResult Update(Shipper shipper)
        {
            //Shipper updated= db.Shippers.Find(shipper.ShipperID);
            // updated.CompanyName = shipper.CompanyName;
            db.Entry(shipper).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            TempData["success"] = $"{shipper.CompanyName} başarılı bir şekilde güncellendi";
            return RedirectToAction("Index");
        }
        //Silme
        public ActionResult Delete(int id)
        {
            Shipper shipper = db.Shippers.Find(id);
            return View(shipper);
        }
        [HttpPost]
        public ActionResult Delete(Shipper model)
        {
           Shipper deleted= db.Shippers.Find(model.ShipperID);
            db.Shippers.Remove(deleted);
            db.SaveChanges();
            TempData["success"] = "Nakliyeci silindi";
            return RedirectToAction("Index");
        }

    }
}

