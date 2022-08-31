using System;

namespace Aula46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valordo raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferencia: {circ.ToString("F2")}");
            Console.WriteLine($"Raio: {volume.ToString("F2")}");
            Console.WriteLine($"Valor de Pi: {Calculadora.Pi}");
        }
    }
}
