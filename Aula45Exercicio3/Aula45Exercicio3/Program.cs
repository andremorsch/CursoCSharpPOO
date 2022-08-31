using System;

namespace Aula45Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Digite os dados do Aluno:");
            Console.Write("Nome: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            student.Score1 = double.Parse(Console.ReadLine());
            student.Score2 = double.Parse(Console.ReadLine());
            student.Score3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"\n\nNota final: {student.FinalScore().ToString("F2")}");
            Console.WriteLine(student.FinalResult());
        }
    }
}
