using SolidPrinciples.DIP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.Validate.Concrete
{
    public class Poultry : IProduct
    {
        public string GetFishCookingInstructions()
        {
            return "Kümes hayvanı böyle pişirilir";
        }
    }
}
