using System;

namespace Aula48
{
    class Program
    {
        static void Main(string[] args)
        {
            double valDolar, qntDolar;
            Console.Write($"Qual a cotação do dólar? ");
            valDolar = double.Parse(Console.ReadLine());
            Console.Write($"Quantos doláres vc vai comprar? ");
            qntDolar = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.Converter(valDolar, qntDolar).ToString("F2")}");
        }
    }
}
