using MVC_Filter.Models.Context;
using MVC_Filter.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Filter.Filters
{
    public class AcFilter : FilterAttribute, IActionFilter
    {
        AppDbContext db = new AppDbContext();
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

            Log log = new Log();
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            log.Date = DateTime.Now;
            log.UserName = "admin";
            log.Description = log.UserName + " tarafından işlem gerçekleştirildi";

            db.Logs.Add(log);
            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log log = new Log();
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            log.Date = DateTime.Now;
            log.UserName = "admin";
            log.Description = log.UserName + " tarafından işlem başlatıldı";
            db.Logs.Add(log);
            db.SaveChanges();
        }
    }
}