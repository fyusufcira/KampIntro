using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Saved to database : "+customer);
        }
    }
}
