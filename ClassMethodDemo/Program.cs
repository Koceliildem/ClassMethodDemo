using System;

namespace ClassMethodDemo
{
    class Program
    {
        private const string v = "05366729234";

        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = "1234546575685";
            customer1.CustomerName = "Ildem";
            customer1.CustomerSurname = "Koceli";
            customer1.PhoneNumber = "05343456776";


            Customer customer2 = new Customer
            {
                CustomerId = "142475384729",
                CustomerName = "Dogukan",
                CustomerSurname = "Yilmaz", 
                 PhoneNumber = "05398765432"
               
            };

            Customer customer3 = new Customer { CustomerId = "43526789432", CustomerName = "Can", CustomerSurname = "Bonomo", PhoneNumber = "05468762345" };


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer3);



       






        }
    }
}
