using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesInClasses
{
    class Customer
    {
        //işte customer2.Firstname="asdsfdsdf" diyosun ya örneğin, bu yaptığın set etmiş olmak oluyor. yani set bloğu çalışıyor bu işlem için.
        //örneğin Console.Writeline(customer2.FirstName) dersek de get bloğu çalışıyor. almış oluyoruz ya programdan
        //alttakiler = property
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
