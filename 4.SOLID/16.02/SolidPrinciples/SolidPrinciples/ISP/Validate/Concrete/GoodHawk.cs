using SolidPrinciples.ISP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Validate.Concrete
{
    public class GoodHawk : IFlyingBird,IFlightless
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
