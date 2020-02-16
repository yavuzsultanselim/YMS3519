using SolidPrinciples.ISP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Validate.Concrete
{
    public class GoodChicken : IFlightless
    {
        public string Walk()
        {
            return "Bu Tavuk yürüyebilir";
        }
    }
}
