using System;
using System.IO;

namespace Aula199Directory_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\André Morsch\Documents\Extras\teste199";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("\nFILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
