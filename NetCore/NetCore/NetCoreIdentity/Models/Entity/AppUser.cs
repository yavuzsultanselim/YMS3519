using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity.Models.Entity
{
    public class AppUser:IdentityUser
    {
        //public int ID { get; set; }
        //public string UserName { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string Address { get; set; }
        public DateTime BirthDate { get; set; }
   

    }
}
