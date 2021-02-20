using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class SellingManager
    {
        public void SellTo(IPerson person)
        {
            Console.WriteLine("Sold product to : " +person.FirstName+" "+person.LastName);




        }

    }
}
