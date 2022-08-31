using System;

namespace diferenceResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, result1, result2, diference;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            result1 = A * B;
            result2 = C * D;
            diference = result1 - result2;

            Console.WriteLine("A diferença é de: " + diference);
        }
    }
}
