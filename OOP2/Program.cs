namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer = new IndividualCustomer();
            customer.Id = 1;
            customer.CustomerNumber = "12345";
            customer.CustomerName = "Atilla";
            customer.CustomerSurname = "Güngör";
            customer.TcNo = "11111111111";

            CoorporateCustomer coorporateCustomer = new CoorporateCustomer();
            coorporateCustomer.Id = 2;
            coorporateCustomer.CustomerNumber = "54321";
            coorporateCustomer.CompanyName = "Kodlama.io";
            coorporateCustomer.TaxNumber = "12345";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}