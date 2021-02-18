using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine("Eklendi:" + product.ProductName);
        }

        public void Update(Product product)
        {

            Console.WriteLine("guncellendi:" + product.ProductName);
        }
    }
}
