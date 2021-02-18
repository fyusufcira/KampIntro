using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager:Customer
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added customer:"+Id);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted:"+Id);
        }
    }
}
