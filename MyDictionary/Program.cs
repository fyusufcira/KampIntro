using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> bookCostCalculator = new MyDictionary<string,int>();
            bookCostCalculator.Add("Suç ve ceza-Dostoyevski",15);
            bookCostCalculator.Add("Shantaram-Gregory David Roberts", 30);
            bookCostCalculator.Add("Yeraltından Notlar-Dostoyevski", 12);
            bookCostCalculator.Add("Nutuk-Gazi Mustafa Kemal Atatürk", 15);
        }
    }
}
