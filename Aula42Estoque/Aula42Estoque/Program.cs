using System;

namespace Aula42Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();

            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do Produto: {p}");

            Console.Write("\n\nDigite a quantidade a ser adicionada em estoque: ");
            int qnt = int.Parse(Console.ReadLine());
            p.AddProdStock(qnt);
            Console.WriteLine($"\nDados atualizados: {p}");

            Console.Write($"\n\nDigite a quantidade a ser removida do estoque: ");
            qnt = int.Parse(Console.ReadLine());
            p.RemoveProdStock(qnt);
            Console.WriteLine($"\nDados Atualizados: {p}");

        }
    }
}
