using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Bad
{
    public class Hawk : IBird
    {
        public string Fly()
        {
            return "Bu şahin uçabilir";
        }

        public string Walk()
        {
            return "Bu şahin yürüyebilir";
        }
    }
}
