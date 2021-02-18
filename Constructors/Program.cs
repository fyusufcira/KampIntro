using System;

namespace Constructors
    //bir class'ı new'lediğimiz zaman çalışan blok aslında.
    //ilk çalıştığı zaman 1 kere çalışır sonra bir daha çalışmaz.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { City = "İstanbul", FirstName = "Fatih Yusuf", Id = 123123, Lastname = "Cira" };
            Customer customer2 = new Customer();
            customer2.FirstName = "Engin";
            customer2.Lastname = "Demiroğ";
            customer2.Id = 123123;
            customer2.City = "istanbul";
            Console.WriteLine(customer2.FirstName);
        
        }
    }
}
