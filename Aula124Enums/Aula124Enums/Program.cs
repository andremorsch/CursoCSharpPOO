using Aula124Enums.Entities;
using Aula124Enums.Entities.Enums;
using System;

namespace Aula124Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order + "\n");

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(txt + "\n" + os);
        }
    }
}
