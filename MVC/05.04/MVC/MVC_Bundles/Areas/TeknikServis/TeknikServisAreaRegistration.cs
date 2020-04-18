using System.Web.Mvc;

namespace MVC_Bundles.Areas.TeknikServis
{
    public class TeknikServisAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TeknikServis";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TeknikServis_default",
                "TeknikServis/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}