using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Customer : IPerson
    {
        public string CustomerNumber { get; set; }
        public int Id { get; set; }
        public string Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
