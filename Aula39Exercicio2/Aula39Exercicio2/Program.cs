using System;

namespace Aula39Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person a, b;

            a = new Person();
            b = new Person();

            Console.WriteLine("Entre com os dados da primeira pessoa");
            Console.Write("Nome: ");
            a.Name = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados da segunda pessoa");
            Console.Write("Nome: ");
            b.Name = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salary = double.Parse(Console.ReadLine());

            double media = (a.Salary + b.Salary) / 2;
            Console.WriteLine("A média do salário é R$" + media.ToString("F2"));
        }
    }
}
