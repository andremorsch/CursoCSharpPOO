using System;

namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id, hoursWorked;
            double paymentPerHour, salary;

            id = int.Parse(Console.ReadLine());
            hoursWorked = int.Parse(Console.ReadLine());
            paymentPerHour = double.Parse(Console.ReadLine());
            salary = hoursWorked * paymentPerHour;

            Console.WriteLine("Funcionário ID: " + id + "\r\nSalário de R$" + salary.ToString("N2"));
        }
    }
}
