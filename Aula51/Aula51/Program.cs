using System;

namespace Aula51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            p.Nome = "TV 4k";
            Console.WriteLine(p.Nome + p.Price);
        }
    }
}
