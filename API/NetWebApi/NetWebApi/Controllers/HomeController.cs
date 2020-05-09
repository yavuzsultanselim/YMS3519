using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApi.Controllers
{
    public class HomeController : ApiController
    {
        #region API Nedir?
        /*
         SOA (Service Oriented Architecture)

--Servis odaklı mimari veya diğer tanımlaması ile hizmet yönelimli mimari bilgisayarlardaki işlevselliklerini iş süreçleri etrafında gruplayarak sistem geliştirilmesine yol gösteren bir yazılım tasarım felsefesidir.

Web Service 

Http protokolü üzerinden xml veya json medya tipleri ile uzak cihazlar arasındaki iletişimi saülayan bir haberleşme yöntemidir.


API (Application Programming Interface)

bir yazılımın baika bir yazılımda tanımlanmış işlevlerini kullanabilmesi için oluşturulmuş bir tanım bütünüdür.

//Apinin belli başlı özellikleri
*GET,POST,PUT,DELETE gibi HTTP metotlarını destekler.

             */ 
        #endregion

        public static List<string> sampleProducts = new List<string>()
        {
            "Chai",
            "Chang",
            "Ikura"
        };
        //localhost:1222/Home

            //Api istekleri varsayılan olarak GET,POST,PUT,DELETE isimli metotları arar. o yüzden metot isimleri önemli.
        public IEnumerable<string> GET()
        {
            return sampleProducts;
        }

        public string Get(int id)
        {
            return sampleProducts[id];
        }

        public void Post([FromBody]string value)
        {
            sampleProducts.Add(value);
        }

        public void Put(int id,[FromBody] string value)//2
        {
            sampleProducts[id] = value;
        }

        public void Delete(int id)
        {
            sampleProducts.Remove(sampleProducts[id]);
        }

    }
}
