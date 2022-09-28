using System;
using System.IO;

namespace Aula195Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Users\André Morsch\Documents\Extras\file1.txt";
            string targetPath = @"c:\Users\André Morsch\Documents\Extras\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
