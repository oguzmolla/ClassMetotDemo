using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Oğuzhan",
                LastName = "Mollaoğlu"
            };
            customers.Add(customer);
            Customer customer2 = new Customer
            {
                Id = 1,
                Name = "Keremcan",
                LastName = "Mollaoğlu"
            };
            customers.Add(customer2);

            Console.WriteLine("Ekleme");
            customerManager.Add(customer);

            Console.WriteLine("Güncelleme");
            customerManager.Update(customer2);

            Console.WriteLine("Silme");
            customerManager.Remove(customer2);

            Console.WriteLine("Customers");
            customerManager.GetAll(customers);
        }
    }
}
