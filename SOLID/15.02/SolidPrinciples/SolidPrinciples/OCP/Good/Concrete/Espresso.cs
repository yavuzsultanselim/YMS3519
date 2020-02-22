using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.Good.Concrete
{
    public class Espresso : GoodCoffee
    {
        public override decimal GetTotalPrice(decimal amount)
        {
            decimal totalPrice = amount * 6;
            return totalPrice;
        }
    }
}
