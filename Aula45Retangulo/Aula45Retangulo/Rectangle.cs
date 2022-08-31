using System;
using System.Collections.Generic;
using System.Text;

namespace Aula45Retangulo
{
    class Rectangle
    {
        public double Height;
        public double Width;

        public double CalculateArea()
        {
            return Height * Width;
        }

        public double CalculatePerimeter()
        {
            return (Height * Width) * 2;
        }

        public double CalculateDiagonal()
        {
            return Math.Sqrt(Height * Height + Width * Width);
        }

        public override string ToString()
        {
            return $"\nÁrea: {CalculateArea().ToString("F2")}" +
                $"\nPerímetro: {CalculatePerimeter().ToString("F2")}" +
                $"\nDiagonal: {CalculateDiagonal().ToString("F2")}";
        }
    }
}
