using DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Api.Service.Models
{
    public class AppUserSecurity
    {
        public static bool Login(string username, string pass)
        {
            AppDbContext db = new AppDbContext();
            return db.AppUsers.Any(x => x.UserName == username && x.Password == pass);
        }
    }
}