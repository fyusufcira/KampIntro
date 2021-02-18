using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Description = "Amasya elması. Al gel";
            product1.Price = 2;

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Description = "Karabük Karpuzu";
            product2.Price = 10;

            Product product3 = new Product();
            product3.Name = "Kitap";
            product3.Description = "Yeni kitap, taze güzel süper.";
            product3.Price = 18.4;
            Product[] products = new Product[] {product1,product2,product3};
           
            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Price);
            }
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);

        }
    }
}
