using System;

namespace Aula60Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char sn = char.Parse(Console.ReadLine());
            double depInicial = 0.00;

            if (sn == 's' || sn == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                depInicial = double.Parse(Console.ReadLine());
            }

            ContaBancaria c = new ContaBancaria(conta, nome, depInicial);

            Console.WriteLine($"\nDados da conta:\n{c}");

            Console.Write("\n\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            c.Deposito(deposito);
            Console.WriteLine($"\nDados da conta atualizados:\n{c}");

            Console.Write("\n\nEntre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            c.Saque(saque);
            Console.WriteLine($"\nDados da conta atualizados:\n{c}");
        }
    }
}
