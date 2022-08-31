using System;

namespace Aula70Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a qnt de produtos a cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }

            double soma = 0, media = 0;
            
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            media = soma / n;

            Console.WriteLine($"\nA média de preços é de R${media.ToString("F2")}");
        }
    }
}
