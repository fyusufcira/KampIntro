using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 15,
                CategoryId = 12,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 100
            };
            //case sensitive(küçük büyük harf duyarlı program.
            //java ve c#)

            //pascal case  //camel case 
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
