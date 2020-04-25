using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIntro.Models
{
    public class Product
    {
        public static List<Product> products = new List<Product>()
        {
            new Product{ID=1,ProductName="Nike",UnitPrice=600,CategoryId=1},
            new Product{ID=2,ProductName="Iphone 11",UnitPrice=7000,CategoryId=2},
            new Product{ID=3,ProductName="Dell",UnitPrice=12000,CategoryId=3},
            new Product{ID=4,ProductName="Çamaşır suyu",UnitPrice=50,CategoryId=3}
        };

        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }


    }
}
