using System;

namespace circleRadius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input, result, pi = 3.14159;

            input = double.Parse(Console.ReadLine());

            result = pi * input * input;

            Console.WriteLine("O Raio do círculo é de: " + result.ToString("N4"));
        }
    }
}
