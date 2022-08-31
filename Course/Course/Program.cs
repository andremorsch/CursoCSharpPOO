using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador", produto2 = "Mesa de Escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0, preco2 = 650.50;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R${preco2:F2} \r\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
        }
    }
}
