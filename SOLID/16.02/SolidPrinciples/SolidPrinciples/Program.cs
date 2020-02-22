using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciples.DIP.Bad;
using SolidPrinciples.DIP.Validate.Abstract;
using SolidPrinciples.DIP.Validate.Concrete;
using SolidPrinciples.LSP.Bad;
using SolidPrinciples.LSP.Good;
using SolidPrinciples.OCP.Bad;
using SolidPrinciples.OCP.Good;
using SolidPrinciples.OCP.Good.Concrete;
using SolidPrinciples.SRP.BadEmployee;
using SolidPrinciples.SRP.GoodEmployee;
using SolidPrinciples.SRP.Model;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID Prensipleri=> Solid, beş önemli OOP prensiplerinin kısaltmasıdır.
            /*
             Temiz, modüler ve genişletilebilir kod yazımında önemli kuralları tanımlar.
             Aynı zamnda Agile yaızlım geliştirme için gereklidir.


            SRP=> Single Responsibility Pricinple.
            //Bir class sadece bir iş yapıyor olmalı.
             */

            //Employee employee = new Employee();
            //employee.ID = 1;
            //employee.FirstName = "Fatih";
            //employee.LastName = "Günalp";
            //employee.HireDate = new DateTime(2020, 02, 02);

            //BadEmployeeProcessor badEmployee = new BadEmployeeProcessor();
            //badEmployee.InsertEmployee(employee);
            //Console.ReadKey();

            //GoodEmployeeProcessor good = new GoodEmployeeProcessor();
            //Console.WriteLine(good.InsertEmployee(employee) ? "Başarılır" : "Başarısız");
            //Console.ReadKey();

            //OCP=> Open/Closed Principle

            /*
             Sınıflar ve metotlar genişletmeye açık değişikliğe kapalı olmalıdır.
             */

            // BadCoffee badCoffee = new BadCoffee();
            //decimal americano= badCoffee.GetTotalPrice(2, CoffeeType.Americano);
            // Console.WriteLine(americano.ToString());
            // Console.ReadKey();

            //GoodCoffee kahve1 = new Espresso();
            //GoodCoffee kahve2 = new Americano();

            //decimal price = 0;
            //price = kahve1.GetTotalPrice(5);

            //Console.WriteLine(price.ToString());
            //Console.ReadKey();


            //LSP=> Liskov's substution principle

            /*
             Bir sınıftan türetilen sınıflar, base sınıfın yerine de kullanılabilmelidir.
             */

            //BadReactangle reactangle = new BadReactangle();
            //reactangle.Width = 2;
            //reactangle.Height = 3;

            //if (BadAreaCalculator.CalculateArea(reactangle) != 6)
            //{
            //    Console.WriteLine("Dörtgen alan hesaplamasında hatalı işlem");
            //}

            //BadSquare square = new BadSquare();
            //square.Height = 3;

            //if (BadAreaCalculator.CalculateArea(square) != 9)
            //{
            //    Console.WriteLine("Kare Alanı hesaplamasında hatalı işlem");
            //}

            //Rectagle rectagle = new Rectagle();
            //rectagle.Width = 2;
            //rectagle.Height = 3;
            //rectagle.Bildirim = "Dörtgen Oluşturuldu";

            //if (rectagle.RectangleArea() != 6)
            //{
            //    Console.WriteLine("Dörtgen Alanı hesaplamasında hata var.");
            //}

            //Square square = new Square();
            //square.Width = 4;
            //square.Bildirim = "Kare Oluşturuldu";

            //if (square.SquareArea() != 16)
            //{
            //    Console.WriteLine("Kare Alanı hesaplamasında hata var.");
            //}

            //ISP => Interface Segregation Principle

            /*
             sınıflar ihtiyaçları olmayan özellik ve davranışları içeren interfaceleri almamalıdır.
             */

            //DIP=> Dependency Inversion Principle

            /*
             Üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.

             */

            //BadRestaurant restaurant = new BadRestaurant();
            //string instructions=restaurant.GenerateInstructions();
            //Console.WriteLine(instructions);
            //Console.ReadKey();
            Fish tuna = new Fish();
            Poultry duck = new Poultry();
            List<IProduct> urunler = new List<IProduct>();
            urunler.Add(tuna);
            urunler.Add(duck);

            Restaurant restaurant = new Restaurant(urunler);
            restaurant.GenerateInstructions();


            Console.WriteLine(restaurant.GenerateInstructions());
            Console.ReadKey();
        }
    }
}
