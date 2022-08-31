using System;

namespace Aula71Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos quartos serão reservados: ");
            int qntQuartos = int.Parse(Console.ReadLine());

            Quartos[] vect = new Quartos[10];

            for (int i = 0; i < qntQuartos; i++)
            {
                Console.WriteLine($"\nRent #{i + 1}:");
                Console.Write("Hospede: ");
                string hospede = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto a ser alugado: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quartos(hospede, email);
            }

            Console.WriteLine($"\n\nQuartos alugados:");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }
        }
    }
}
