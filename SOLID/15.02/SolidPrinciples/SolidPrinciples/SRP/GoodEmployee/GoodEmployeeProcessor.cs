using SolidPrinciples.SRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.GoodEmployee
{
    public class GoodEmployeeProcessor
    {
        Logger logger;
        string log;

        public GoodEmployeeProcessor()
        {
            logger = new Logger();
        }

        public bool InsertEmployee(Employee employee)
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
                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\SRP\EmployeeData1.txt", log);

                sb = new StringBuilder();
                sb.Append("Personel Added: ");
                sb.AppendLine();
                sb.Append(employee.FirstName).Append(" ");
                sb.Append(employee.LastName);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\SRP\Log1.txt", log);

                return true;

            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata Mesajı: ");
                sb.AppendLine();
                sb.Append(ex.Message);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\SRP\LogError.txt", log);

                return false;

            }
        }

    }
}
