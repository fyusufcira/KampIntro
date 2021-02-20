using System;

namespace PropertiesInClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Yusuf";
            customer1.LastName = "Çıra";
            customer1.Id = 234234;
            customer1.City = "İstanbul";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Ankara",
                FirstName = "Fatih",
                LastName = "Çıra"
            };
            Console.WriteLine(customer2.FirstName);
        }
    }
}
