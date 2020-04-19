//Filters

Asp.Net MVC'de kullanıcının isteği uygun denetleyiciye eylem yöntemine yönlendirilir. Bununla birlikte bir eylem yönteminin çalıştırılmasından önce veya çalıştıktan sonra bazı mantık işlemleri yürütmek istediğimiz durumalr olabilir. Bu tip durumlar Filter yapılarını kullanabiliriz.

IAuthorizationFilter => yetki filitrelemeleri
IActionFilter => Actionlar için kullanılan filitreler
IExceptionFilter=> Hata filitreleri.

//AppUser
//Log