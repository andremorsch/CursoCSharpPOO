using System;
using System.Collections.Generic;
using System.Text;

namespace Aula241ExercicioResolvido.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
