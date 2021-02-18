using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            CustomerManager customerManager = new CustomerManager();
            
            customerManager.Add(customer1);
            
            customer1.Id = 1234324;
            customer1.FirstName = "Yusuf";
            customer1.LastName = "Çıra";
            customer1.Age = 19;

            Customer customer2 = new Customer();
            customerManager.Add(customer2);
            customer2.Id = 21311;
            customer2.Age = 19;
            customer2.FirstName = "Semiha";
            customer2.LastName = "Savaşçı";


        }
    }
}
