using Aula145ExercicioResolvido.Entities;
using Aula145ExercicioResolvido.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Aula145ExercicioResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>(); 

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nShape #{i+1} data:");
                Console.Write("Rectangle or circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("\n\nShape Areas:");
            foreach (Shape shape in list)
            {
                Console.WriteLine($"{shape.Area():F2}");
            }
        }
    }
}
