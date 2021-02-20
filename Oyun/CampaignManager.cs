using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class CampaignManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Campaign added to : " + person.FirstName + " " + person.LastName);

        }

        public void Delete(IPerson person) {
            Console.WriteLine("Campaign Deleted from : " + person.FirstName + " " + person.LastName);

        }
        void Update(IPerson person) {
            Console.WriteLine("Campaign updated for : " + person.FirstName + " " + person.LastName);
        }
    }
}
