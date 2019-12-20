using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.State
{
    public class Delivered : OrderState

    { 
        public override void CheckOrder(Order order)
        {
            Console.WriteLine("Your order has been delivered");
            order.RateOrder();
        }
    }
}
