using System;
using System.Collections.Generic;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> products = new MyDictionary<int, string>();
            products.Add(1, "Apple");
            products.Add(2, "Banana");
            products.Add(3, "Watermelon");
            products.Add(4, "Mellon");
            products.Add(5, "Kiwi");
            products.Add(6, "Orange");
            products.Add(7, "Pineapple");

            products.All();
        }
    }
}
