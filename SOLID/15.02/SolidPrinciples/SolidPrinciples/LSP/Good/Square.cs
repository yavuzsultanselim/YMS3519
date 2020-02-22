using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Good
{
    public class Square:Shape
    {
        public int Width { get; set; }
        public double SquareArea()
        {
            return Width * Width;
        }
    }
}
