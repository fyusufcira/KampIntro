using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string username = Console.ReadLine();
            Console.WriteLine(username);

            Console.WriteLine("Enter AGE:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);
            //tip güvenliği - type safety
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(i);
            }
            string[] kurslar = new string[] {"yazılım geliştirme kampı","programlama başlangıç kursu","java" };
            string kategoriEdiketi = "Kategoriler";
            int ogrenciSayisi= 32000;
            bool dogruMu = false;
            if (dogruMu == true) { Console.WriteLine(kategoriEdiketi); }
            else Console.WriteLine("false");
            Console.WriteLine(kategoriEdiketi);
            Console.WriteLine(kategoriEdiketi);
            Console.WriteLine(kategoriEdiketi);
            Console.WriteLine(kategoriEdiketi);
            Console.WriteLine(kategoriEdiketi);
            Console.WriteLine(kategoriEdiketi);
           

        }
    }
}
