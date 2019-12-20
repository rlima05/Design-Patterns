using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.State
{
    public class Confirmed : OrderState
    {
        public override void CheckOrder(Order order)
        {
            Console.WriteLine("The restaurant has confirmed your order, and it is preparing now...");
            System.Threading.Thread.Sleep(5000);
            order.TransitionTo(new Delivering());
        }
    }
}
