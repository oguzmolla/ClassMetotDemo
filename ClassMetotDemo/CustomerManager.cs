using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.ToString() +" Kişisi eklendi." );
        }

        public void GetAll(List<Customer> customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.ToString() + " Kişisi silindi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.ToString() + " Kişisi güncenlendi.");
        }
    }
}
