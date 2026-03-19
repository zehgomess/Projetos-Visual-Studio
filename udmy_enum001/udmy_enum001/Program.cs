using System;
using System.Globalization;
using udmy_enum001.entities;
using udmy_enum001.entities.enums;

namespace udmy_enum001
{
    class Program
    {
        static void Main(string[] args)
        {
            order order = new order
            {
                id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);


        }
    }
}