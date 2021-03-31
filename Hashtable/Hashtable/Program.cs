using System;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Demo..");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");

            string hash3 = hash.Get("3");
            Console.WriteLine("3rd index value: " + hash3);
            string hash2 = hash.Get("2");
            Console.WriteLine("2nd index value: " + hash2);
            string hash17 = hash.Get("17");
            Console.WriteLine("17th index value: " + hash17);
            hash.Remove("17");
            Console.WriteLine("17th index value removed.. ");
            Console.ReadKey();
        }
    }
    }
}
