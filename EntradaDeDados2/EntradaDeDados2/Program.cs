using System;

namespace EntradaDeDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nome Completo?");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Qual idade");
            //int idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual sua altura?");
            //double altura = double.Parse(Console.ReadLine());

            //area do circulo
            double pi = 3.14159;
            Console.WriteLine("Digite o raio do circulo");
            double raio = double.Parse(Console.ReadLine());
            double area;
            area = pi * (raio * raio);
            Console.WriteLine("A area do circulo é de " + area.ToString("N4"));
        }
    }
}
