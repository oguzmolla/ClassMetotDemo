using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(Customer customer);
        void GetAll(List<Customer> customers);
    }
}
