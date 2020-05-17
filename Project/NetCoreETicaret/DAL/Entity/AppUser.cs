using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    //Microsoft.AspNetCore.Identity.EntityFrameworkCore kütüphanesine ihtiyacınız var.
    public class AppUser:IdentityUser<Guid>
    {

    }
}
