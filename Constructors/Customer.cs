using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Customer
    {
        public Customer() 
        { 
        
        }
        
        //default constructor denir alttaki constructora
        public Customer(int id,string firstName,string lastName,string city)
        {
            Console.WriteLine("Yapıcı blok çalıştı.");
            FirstName = firstName;
            Lastname = lastName;
            Id = id;
            City = city;
        }
        public int Id {get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }

    }
}
