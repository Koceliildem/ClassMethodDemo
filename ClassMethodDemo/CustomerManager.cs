using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
        
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerId +":"+ "Added!");
            Console.WriteLine(customer.CustomerName+ ":" + "Added!");
            Console.WriteLine(customer.CustomerSurname+ ":" + "Added!");
            Console.WriteLine(customer.PhoneNumber +":" + "Added!");

        }
        public void Delete(Customer customer)
        {

            Console.WriteLine(customer.CustomerId + ":" +  "Deleted!");
            Console.WriteLine(customer.CustomerName + ":" + "Deleted!");
            Console.WriteLine(customer.CustomerSurname + ":" + "Deleted!");
            Console.WriteLine(customer.PhoneNumber + ":" + "Deleted");

        }
        







    }
}
