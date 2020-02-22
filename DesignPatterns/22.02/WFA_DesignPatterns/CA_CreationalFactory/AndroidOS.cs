using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CreationalFactory
{
    public class AndroidOS : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("Bu uygulama andrid için çalışmaktadır");
        }
    }
}
