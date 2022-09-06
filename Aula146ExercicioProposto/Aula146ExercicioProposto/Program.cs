using Aula146ExercicioProposto.Entities;
using System;
using System.Collections.Generic;

namespace Aula146ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (ic == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (ic == 'c')
                {
                    Console.Write("Number of employees: ");
                    int qntEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, qntEmployees));
                }
            }

            Console.WriteLine("\n\nTAXES PAID:");
            double sumTax = 0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine($"{taxPayer.Name}: ${taxPayer.Tax():F2}");
                sumTax += taxPayer.Tax();
            }

            Console.WriteLine($"\nTotal Taxes: ${sumTax:F2}");
        }
    }
}
