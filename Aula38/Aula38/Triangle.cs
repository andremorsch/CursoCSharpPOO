using System;

namespace Aula38
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;

        public double CalculateArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
