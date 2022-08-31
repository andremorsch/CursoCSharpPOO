using System;
using System.Collections.Generic;

namespace Aula78Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be regitered? ");
            int qntEmployees = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < qntEmployees; i++)
            {
                Console.WriteLine($"\nEmployee #{i+1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee Id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("\nEnter the percentage to increase: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This Id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
