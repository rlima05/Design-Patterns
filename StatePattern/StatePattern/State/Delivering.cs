using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.State
{
    public class Delivering : OrderState
    {
        public override void CheckOrder(Order order)
        {
            Console.WriteLine("Your order is out for delivery");
            System.Threading.Thread.Sleep(5000);
            order.TransitionTo(new Delivered());
        }
    }
}
