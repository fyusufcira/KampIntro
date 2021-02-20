using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class PersonManager
    {
        public void Add(IPerson person) {
            Console.WriteLine("Person added : " + person.FirstName + " " + person.LastName);
        }
        public void Delete(IPerson person) { Console.WriteLine("Person deleted : " + person.FirstName + " " + person.LastName); }
        public void Update(IPerson person) { Console.WriteLine("Person updated : " + person.FirstName + " " + person.LastName); }
    }
}
