using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;//=>Controller

namespace MVCIntro.Controllers
{
    
    public class HomeController : Controller
    {
        //Controller
        /*
         Projenin merkez noktasıdır. View ile Model arasındaki işlemleri gerçekleştiren katmandır. Controller yapısında bulunan varsayılan yapı /Home/Index => Controller ve Metot
         */

            /*
             ViewEngine

            .Net Mvc ile karşımıza çıkan bir yeniliktir ve ViewEngine tekonolojisi sayesinde Html kodları arasına C# kodlarını yazabiliriz.

                4 farklı View Engine bulunmaktadır.
        * Razor => html içerisinde C# kodlarımızı yazmamızı sağlar.
        * Web Form
        * Spark
        * Nhalm
        * 
        * View klasörü altında bulunan html sayfaları cshtml uzantılı olmalıdır.
             */
       
        public ViewResult Index()
        {
            return View();
        }


        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        //View klasörü içerisindeki html sayfalarının uzantısı neden cshtml?


    }
}