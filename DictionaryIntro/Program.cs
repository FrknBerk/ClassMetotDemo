using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Furkan");
            myDictionary.Add(2, "Berk");
            myDictionary.List();
            Console.WriteLine("*************************");
            myDictionary.Add(3, "Mert");
            myDictionary.List();
            Console.WriteLine(myDictionary.Count);


            Console.ReadKey();
        }
    }
}
