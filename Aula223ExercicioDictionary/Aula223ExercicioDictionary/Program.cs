using System;
using System.Collections.Generic;
using System.IO;

namespace Aula223ExercicioDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Pessoal2\Aula223ExercicioDictionary\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> candidatos = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string nome = line[0];
                        int voto = int.Parse(line[1]);

                        if (candidatos.ContainsKey(nome))
                        {
                            candidatos[nome] += voto;
                        }
                        else
                        {
                            candidatos[nome] = voto;
                        }
                    }

                    foreach (KeyValuePair<string, int> item in candidatos)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
