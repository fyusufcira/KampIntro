using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];

        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempArrayKey = keys;
            TValue[] tempArrayValue = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i <tempArrayKey.Length; i++)
            {
                keys[i]=tempArrayKey[i];
            }
            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                values[i]=tempArrayValue[i] ;
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


            Console.WriteLine("Kitap Adı: " + key + "   Kitap Ücreti:" + value);
            
            
        }
        
    }
}
