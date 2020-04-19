using MVC_Filter.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Filter.Models.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=FiltersDB;uid=sa;pwd=123";
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Log> Logs { get; set; }

    }
}