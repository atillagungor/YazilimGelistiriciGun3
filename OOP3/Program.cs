namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelFinanceCredit = new PersonelFinanceCredit();  
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Application(mortgageCreditManager, new List<ILoggerService> { new DatabaseLoggerService(),new FileLoggerService()});

            List<ICreditManager> credits = new List<ICreditManager>() {personelFinanceCredit, vehicleCreditManager };

            //applicationManager.CreditPreliminaryInformation(credits);
        }
    }
}