using System;
using System.Collections.Generic;

namespace Aula221ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the student code: ");
                int x = int.Parse(Console.ReadLine());
                a.Add(x);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the student code: ");
                int x = int.Parse(Console.ReadLine());
                b.Add(x);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the student code: ");
                int x = int.Parse(Console.ReadLine());
                c.Add(x);
            }

            HashSet<int> total = new HashSet<int>(a);
            total.UnionWith(b);
            total.UnionWith(c);
            Console.WriteLine($"\nTotal students: {total.Count}");
        }
    }
}
