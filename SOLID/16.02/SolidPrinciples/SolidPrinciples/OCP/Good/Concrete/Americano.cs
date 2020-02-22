using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.Good.Concrete
{
    public class Americano : GoodCoffee
    {
        public override decimal GetTotalPrice(decimal amount)
        {
            decimal totalPrice = amount * 9;
            return totalPrice;
        }
    }
}
