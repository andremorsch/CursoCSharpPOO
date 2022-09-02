using Aula142Exercicio.Entities;
using System;
using System.Collections.Generic;

namespace Aula142Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            int productsQuantity = int.Parse(Console.ReadLine());

            for(int i = 0; i < productsQuantity; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char cui = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                
                if (cui == 'c')
                {
                    listProducts.Add(new Product(name, price));
                }
                else if (cui == 'u')
                {
                    Console.Write("Manufacturate date (DD/MM/YYYY): ");
                    DateTime manufacturateDate = DateTime.Parse(Console.ReadLine());

                    listProducts.Add(new UsedProduct(name, price, manufacturateDate));
                }
                else if (cui == 'i')
                {
                    Console.Write("Custom fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    listProducts.Add(new ImportedProduct(name, price, fee));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in listProducts)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
