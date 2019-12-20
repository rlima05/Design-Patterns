using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();

            order.DoOrder();

            Console.ReadKey();
        }
    }
}
