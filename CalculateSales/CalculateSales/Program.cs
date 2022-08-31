using System;

namespace CalculateSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id1, qntPieces1, id2, qntPieces2;
            double price1, totalSale1, price2, totalSale2, totalSale;

            id1 = int.Parse(Console.ReadLine());
            qntPieces1 = int.Parse(Console.ReadLine());
            price1 = double.Parse(Console.ReadLine());
            totalSale1 = qntPieces1 * price1;

            id2 = int.Parse(Console.ReadLine());
            qntPieces2 = int.Parse(Console.ReadLine());
            price2 = double.Parse(Console.ReadLine());
            totalSale2 = qntPieces2 * price2;

            totalSale = totalSale1 + totalSale2;

            Console.WriteLine("Preço total a pagar R$ " + totalSale.ToString("N2"));

        }
    }
}
