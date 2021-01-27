using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> magazaUrunler = new MyDictionary<string, string>();

            magazaUrunler.Add("Huawei", "1000");
            magazaUrunler.Add("Samsung", "2000");
            magazaUrunler.Add("Apple", "3000");

            foreach (var keys in magazaUrunler.Keys)
            {
                Console.WriteLine(keys);
            }
            foreach (var values in magazaUrunler.Values)
            {
                Console.WriteLine(values);
            }

            // bunları daha düzgün dursun diye yan yana da yazdırabilirsiniz.

        }

   


    }
}
