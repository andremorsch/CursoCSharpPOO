using Aula135Heranca.Entities;
using System;

namespace Aula135Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //// UPCASTING

            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //// DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.00);
            //// acc2.Loan(100.00); Da ruim

            ////BusinessAccount acc5 = (BusinessAccount)acc3; // Vai dar erro no compilado pois acc3 vem de SavingsAccount
            //if (acc3 is BusinessAccount)
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.00);
            //    Console.WriteLine("Loan!");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3; Sintaxe alternativa 1
            //    SavingsAccount acc5 = acc3 as SavingsAccount; // Sintaxe alternativa 2
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Updated!");
            //}


            // Aula 137

            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
