using Aula145ExercicioResolvido.Entities.Enums;

namespace Aula145ExercicioResolvido.Entities
{
    abstract class Shape
    {
        public  Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
