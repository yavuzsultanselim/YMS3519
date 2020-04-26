using NetCoreDepencyInjection.Models.Abstract;
using NetCoreDepencyInjection.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDepencyInjection.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        List<Category> categories = new List<Category>()
        {
            new Category{ID=1,CategoryName="Yiyecek"},
            new Category{ID=1,CategoryName="İçecek"},

        };
        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
