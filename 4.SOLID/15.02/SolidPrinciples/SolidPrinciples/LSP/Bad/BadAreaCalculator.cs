using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Bad
{
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadReactangle reactangle)
        {
            return reactangle.Height * reactangle.Width;
        }

        public static double CalculateArea(BadSquare square)
        {
            return square.Height * square.Width;
        }
    }
}
