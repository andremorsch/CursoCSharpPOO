using System;
using System.Collections.Generic;
using System.Text;

namespace Aula42Estoque
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalValueStock()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Name}, ${Price.ToString("F2")}, {Quantity} unidades, Total: ${TotalValueStock().ToString("F2")}";
        }

        public void AddProdStock(int qnt)
        {
            Quantity += qnt;
        }

        public void RemoveProdStock(int qnt)
        {
            Quantity -= qnt;
        }
    }
}
