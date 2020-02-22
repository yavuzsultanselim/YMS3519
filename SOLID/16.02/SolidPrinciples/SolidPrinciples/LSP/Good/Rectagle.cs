using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Good
{
    public class Rectagle:Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public double RectangleArea()
        {
            return Width * Height;
        }
    }
}
