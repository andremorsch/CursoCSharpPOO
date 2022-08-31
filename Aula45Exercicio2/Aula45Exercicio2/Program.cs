using System;

namespace Aula45Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine("Escreva os dados do Funcionário:");
            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            employee.Salary = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nFuncionário: {employee}");

            Console.Write("\n\nDigite a porcentagem de aumento do salário: ");
            double upgrade = double.Parse(Console.ReadLine());
            employee.UpgradeSalary(upgrade);

            Console.WriteLine($"Dados atualizados: {employee}");
        }
    }
}
