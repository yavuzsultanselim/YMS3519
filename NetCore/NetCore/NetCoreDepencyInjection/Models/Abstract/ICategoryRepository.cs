using NetCoreDepencyInjection.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDepencyInjection.Models.Abstract
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();

    }
}
