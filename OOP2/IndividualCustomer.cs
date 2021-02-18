using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //alttaki :customer yapınca inheritance yapmıs demek oluyoruz
    class IndividualCustomer:Customer
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNumber { get; set; }
    }
}
