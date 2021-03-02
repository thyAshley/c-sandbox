using System;

namespace Methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "james");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 2, 2, 3, 1));
            Console.WriteLine(calculator.Add(new int[] { 1, 3, 5, 4, 2 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(15, 30);

                Console.WriteLine(point.X);

                point.Move(new Point(100, 200));
                Console.WriteLine(point.X);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured");
            }

        }
    }
}
