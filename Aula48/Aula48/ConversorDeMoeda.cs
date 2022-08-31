using System;
using System.Collections.Generic;
using System.Text;

namespace Aula48
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.00;

        public static double Converter(double qnt, double val)
        {
            double total = qnt * val;
            return total + (total * (IOF / 100));
        }
    }
}
