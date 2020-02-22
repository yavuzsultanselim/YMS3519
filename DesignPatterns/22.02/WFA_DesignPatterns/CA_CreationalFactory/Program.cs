using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CreationalFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Factory Method

                creational grubuna ait, aynı arayüzü kullanan nesnelerin üretiminden sorumlu tasarım desenidir. 
             */

            Creater cr = new Creater();
            MobileApplication MobileAndroid = cr.FactoryMethod(AllMobileOs.android);
            MobileApplication MobileIphone = cr.FactoryMethod(AllMobileOs.iphone);
            MobileApplication MobileWindows = cr.FactoryMethod(AllMobileOs.windows);

            MobileIphone.Platform();
            MobileWindows.Platform();
            MobileAndroid.Platform();

            Console.ReadKey();

        }
    }
}
