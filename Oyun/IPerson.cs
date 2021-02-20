using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
