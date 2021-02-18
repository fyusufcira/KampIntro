using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string>();
            isimler2.Add("Engin");
            //veya
            List<string> isimler3 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            Console.WriteLine(isimler3[3]);
            isimler3.Add("Yusuf");
            Console.WriteLine(isimler3[4]);

        }
    }
}
