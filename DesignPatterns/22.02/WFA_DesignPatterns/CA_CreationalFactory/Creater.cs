using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CreationalFactory
{
    public class Creater
    {
        public MobileApplication FactoryMethod(AllMobileOs osType)//iphone
        {
            MobileApplication ma = null;
            switch (osType)
            {
                case AllMobileOs.android:
                    ma = new AndroidOS();
                    break;
                case AllMobileOs.iphone:
                    ma = new IPhoneOS();
                    break;
                case AllMobileOs.windows:
                    ma = new WindowsOS();
                    break;

            }
            return ma;
        }
    }
}
