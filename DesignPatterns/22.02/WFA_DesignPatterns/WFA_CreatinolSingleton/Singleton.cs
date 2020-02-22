using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CreatinolSingleton
{
    public class Singleton
    {
        //Constructor private yapılarak bu sınıf dışında instance alınmasını engelleliyoruz.
        private Singleton() { }

        private static Singleton _nesne = new Singleton();


        //oluşturulan static nesnenin dışarıdan erişilmesini sağlamak için property tanımlandı.
        public static Singleton Sinif
        {
            get
            {
                return _nesne;
            }
        }

        //Oluşturulan static nesnenin dışarıdan erilmesini sağlayabilmek adına dilerseniz metot yazabilirsiniz.
        public static Singleton Sinif2()
        {
            return _nesne;
        }



        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
