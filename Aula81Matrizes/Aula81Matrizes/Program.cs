using System;

namespace Aula81Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantidades de linhas");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantidades de colunas");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Digite a linha #{i}");
                string[] numbers = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(numbers[j]);
                }
            }
            Console.Write("Numeroa a buscar: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine($"Position {i}, {j}:");

                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
