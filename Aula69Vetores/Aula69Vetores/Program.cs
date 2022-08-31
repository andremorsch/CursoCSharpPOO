using System;

namespace Aula69Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0.0, media;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            media = sum / n;

            Console.WriteLine($"A média é {media.ToString("F2")}");
        }
    }
}
