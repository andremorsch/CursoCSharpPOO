using System;
using System.Collections.Generic;

namespace Aula222DictionaryAndSortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99711122";
            cookies["phone"] = "99999999";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");
            Console.WriteLine(cookies.ContainsKey("email"));

            Console.WriteLine($"Size: {cookies.Count}");
            Console.WriteLine("ALL COOKIES:");

            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
