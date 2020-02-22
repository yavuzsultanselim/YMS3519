using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CreatinolSingleton
{
    public class Singleton2
    {
         private Singleton2() { }

        private static Singleton2 _db;

        public static Singleton2 Instance
        {
            get
            {
                if (_db == null)
                {
                    _db = new Singleton2();
                }
                return _db;
            }
        }


        public string Yaz(string param)
        {
            return param;
        }
    }
}
