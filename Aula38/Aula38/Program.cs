using System;

namespace Aula38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Entre com medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.CalculateArea();
            double areaY = y.CalculateArea();

            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Área: X");
            }
            else
            {
                Console.WriteLine("Maior Área: Y");
            }
        }
    }
}
