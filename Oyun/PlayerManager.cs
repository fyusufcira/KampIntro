using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class PlayerManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Player Added : "+person.FirstName + " " + person.LastName);
        }

        public void Delete(IPerson person)
        {
            Console.WriteLine("Player Deleted : "+person.FirstName + " " + person.LastName);
        }

        public void Update(IPerson person)
        {
            Console.WriteLine("Player Updated : " + person.FirstName + " " + person.LastName);
        }
    }
}
