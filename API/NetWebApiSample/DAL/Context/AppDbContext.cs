using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
   public  class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=WebApiSampleDB;uid=sa;pwd=123";
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
