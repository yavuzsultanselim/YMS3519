using SolidPrinciples.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BadEmployee
{
    public class BadEmployeeProcessor
    {
        public void InsertEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(employee.ID);
                sb.AppendLine();
                sb.Append(employee.FirstName);
                sb.AppendLine();
                sb.Append(employee.LastName);
                sb.AppendLine();
                sb.Append(employee.HireDate);
                File.WriteAllText(@"C:\SRP\EmployeeData.txt", sb.ToString());

                sb = new StringBuilder();
                sb.Append("Kayıt Ekleme Tarihi");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Personel ID");
                sb.Append(employee.FirstName).Append(" ");
                sb.Append(employee.LastName);
                File.WriteAllText(@"C:\SRP\Log.txt", sb.ToString());

                Console.WriteLine("Çalışan Başarıyla Kaydedili");

            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata Tarihi:");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata Mesajı:");
                sb.Append(ex.Message);

                File.WriteAllText(@"C:\SRP\Log.txt", sb.ToString());

                Console.WriteLine("Hata");
                
            }
        }
    }
}
