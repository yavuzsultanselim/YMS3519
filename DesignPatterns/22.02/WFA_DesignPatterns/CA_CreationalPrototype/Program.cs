using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CreationalPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g1 = new Game(1, "Counter Strike", "MultiPlayer", true);
            //
            /**/
            Game g2 = (Game)g1.Clone();


            if (g1.Equals(g2))
            {
                Console.WriteLine("tipler aynı");
            }
            else
            {
                Console.WriteLine("tipler farklı");
            }

            Console.ReadKey();


        }
    }
}
