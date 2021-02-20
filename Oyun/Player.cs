using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class Player:IPerson
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
