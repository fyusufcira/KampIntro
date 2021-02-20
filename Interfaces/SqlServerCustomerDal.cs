using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted"  );
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }
    }
}
