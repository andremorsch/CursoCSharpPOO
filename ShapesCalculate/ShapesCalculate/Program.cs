using System;

namespace ShapesCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangle, circle, trapeze, square, rectangle, pi = 3.14159;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            triangle = (a * c) / 2;
            circle = (c * c) * pi;
            trapeze = ((a + b) * c) / 2;
            square = b * b;
            rectangle = a * b;

            Console.WriteLine("Triangulo: " + triangle.ToString("N3") + "\r\nCirculo: " + circle.ToString("N3") + "\r\nTrapezio: " + trapeze.ToString("N3") + "\r\nQuadrado: " + square.ToString("N3") + "\r\nRetangulo: " + rectangle.ToString("N3"));
        }
    }
}
