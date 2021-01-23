using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;            //Bu kısımda ne yapmış olduk?
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];

        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];


            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            for (int j = 0; j < tempKeys.Length; j++)
            {
                if (key == null)
                {
                    throw new ArgumentNullException("Key cannot be found");
                }
                else if (tempKeys[j].Equals(key))
                {
                    throw new ArgumentException("Same key cannot use for different values.");
                }

            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


            //Dictionary class ı için iki kural var:
            //1- Farklı 2 value için aynı key kullanılamaz
            //2- Key null (boş) olamaz
            //Bu durumlarda programın hata vermesi gerekir. 
        }

        public void All()
        {
            int i = 0;

            while (i < keys.Length)
            {
                Console.WriteLine(keys[i] + " : " + values[i]);

                i++;
            }

        }









    }
}
