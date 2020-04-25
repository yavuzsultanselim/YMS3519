using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIntro.Models
{
    public class Users
    {
        public static List<Users> users = new List<Users>()
        {
            new Users{UserName="admin",Email="admin@admin.com",Password="123"}
        };

        //kullanıcı adı
        public string UserName { get; set; }
        //email
        public string Email { get; set; }
        //şifre
        public string Password { get; set; }

    }
}
