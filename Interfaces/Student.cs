using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Student:IPerson
    {
        public string StudentNumber { get; set; }
        public int Id { get; set; }
        public string Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
    }
}
