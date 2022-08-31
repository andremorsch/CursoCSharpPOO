using System;

namespace Aula45Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Entre com a Altura e Largura do Retângulo:");
            rectangle.Height = double.Parse(Console.ReadLine());
            rectangle.Width = double.Parse(Console.ReadLine());

            Console.WriteLine(rectangle);
        }
    }
}
