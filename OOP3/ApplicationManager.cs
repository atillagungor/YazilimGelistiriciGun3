using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Method Injection
        public void Application(ICreditManager creditManager,List<ILoggerService> loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            creditManager.Calculate();
            foreach (var loggerServices in loggerService)
            {
                loggerServices.Log();
            }
        }

        public void CreditPreliminaryInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
