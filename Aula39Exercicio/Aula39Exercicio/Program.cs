using System;

namespace Aula39Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person a, b;

            a = new Person();
            b = new Person();

            Console.WriteLine("Entre com o nome e idade da primeria pessoa");
            a.Name = Console.ReadLine();
            a.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome e idade da segunda pessoa");
            b.Name = Console.ReadLine();
            b.Age = int.Parse(Console.ReadLine());

            if (a.Age > b.Age)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.Name);
            }
        }
    }
}
