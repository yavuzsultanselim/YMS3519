using SolidPrinciples.DIP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.Validate.Concrete
{
    public class Restaurant
    {
        private List<IProduct> products;

        public Restaurant(List<IProduct> _products)
        {
            products = _products;
        }

        public string GenerateInstructions()
        {
            string Instructions = string.Empty;
            foreach (var item in products)
            {
                Instructions += item.GetFishCookingInstructions();
            }
            return Instructions;
        }


        
    }
}
