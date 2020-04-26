using NetCoreDepencyInjection.Models.Abstract;
using NetCoreDepencyInjection.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDepencyInjection.Models.Repository
{
    public class FakeProductRepository : IProductRepository
    {
        List<Product> products = new List<Product>()
            {
                new Product{ID=1,ProductName="Ayakkabı",UnitPrice=5},
                new Product{ID=2,ProductName="Çanta",UnitPrice=5},
                new Product{ID=3,ProductName="Tablet",UnitPrice=5},

            };
        public Product GetById(int id)
        {
            return products.FirstOrDefault(x => x.ID == id);
        }

        public List<Product> Products()
        {

            return products;
        }
    }
}
