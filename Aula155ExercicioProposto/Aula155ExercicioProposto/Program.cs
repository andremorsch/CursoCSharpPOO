using Aula155ExercicioProposto.Entities;
using Aula155ExercicioProposto.Entities.Exceptions;
using System;

namespace Aula155ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int numberAcc = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            try
            {
                Account account = new Account(numberAcc, holder, initialBalance, withdrawLimit);

                Console.Write("\nEnter the amount for Withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                account.Withdraw(withdraw);

                Console.WriteLine($"New balance: ${account.Balance}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}
