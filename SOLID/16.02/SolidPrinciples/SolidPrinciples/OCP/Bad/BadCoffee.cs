using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.Bad
{
    public enum CoffeeType
    {
        Espresso,
        Latte,
        Americano
    }
    public class BadCoffee
    {
        

        public decimal GetTotalPrice(decimal amount, CoffeeType coffeeType )
        {
            decimal totalPrice = 0;

            if (coffeeType == CoffeeType.Espresso)
            {
                totalPrice = amount * 6;
            }
            else if (coffeeType == CoffeeType.Latte)
            {
                totalPrice = amount * 8;
            }
            else if (coffeeType == CoffeeType.Americano)
            {
                totalPrice = amount * 9;
            }
            return totalPrice;
        }
    }
}
