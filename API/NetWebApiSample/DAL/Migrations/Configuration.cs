namespace DAL.Migrations
{
    using DAL.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Context.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.Context.AppDbContext context)
        {
            //Products
            if (!context.Products.Any())//true
            {
                List<Product> products = new List<Product>()
                {
                    new Product{ProductName="Kola",UnitPrice=10,UnitsInStock=200},
                    new Product{ProductName="Fanta",UnitPrice=15,UnitsInStock=200},
                    new Product{ProductName="Sprite",UnitPrice=10,UnitsInStock=300}

                };
                foreach (var item in products)
                {
                    context.Products.Add(item);
                }
            }

            //Appusers

            if (!context.AppUsers.Any())
            {
                List<AppUser> appUsers = new List<AppUser>
                {
                    new AppUser{UserName="admin",Password="123"}
                };
                foreach (var item in appUsers)
                {
                    context.AppUsers.Add(item);
                }
            }
            
        }
    }
}
