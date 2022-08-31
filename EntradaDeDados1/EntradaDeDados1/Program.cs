using System;

namespace EntradaDeDados1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine(), y = Console.ReadLine(), z = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(" ");
            string p1 = vet[0], p2 = vet[1], p3 = vet[2];

            Console.WriteLine("vc digitou ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
