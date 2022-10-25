using Aula242ExerciciosLambdaDelegatesLINQ.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Aula242ExerciciosLambdaDelegatesLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Pessoal2\Aula242ExerciciosLambdaDelegatesLINQ\in.txt";

            Console.Write("Enter salary: ");
            double salaryLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine($"Email of people whose salary is more than {salaryLimit.ToString("F2", CultureInfo.InvariantCulture)}:");

            var emails = list.Where(x => x.Salary > salaryLimit).OrderBy(x => x.Email).Select(x => x.Email);
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }


            var salariesWithM = list.Where(x => x.Name[0] == 'M').Sum(x => x.Salary);
            Console.Write($"Sum of salary of people whose name starts with 'M': {salariesWithM.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
