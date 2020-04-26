using NetCoreDepencyInjection.Models.Abstract;
using NetCoreDepencyInjection.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDepencyInjection.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        List<Product> products = new List<Product>()
            {
                new Product{ID=1,ProductName="Kola",UnitPrice=5},
                new Product{ID=2,ProductName="Fanta",UnitPrice=5},
                new Product{ID=3,ProductName="Sprite",UnitPrice=5},

            };
        public Product GetById(int id)
        {
          return  products.FirstOrDefault(x => x.ID == id);
        }

        public List<Product> Products()
        {
            
            return products;
        }

        
    }
}
