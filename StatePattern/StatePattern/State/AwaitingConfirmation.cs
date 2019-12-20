using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.State
{
    public class AwaitingConfirmation : OrderState
    {
        public override void CheckOrder(Order order)
        {
            Console.WriteLine("Confirming your order with the restaurante...");
            System.Threading.Thread.Sleep(5000);
            order.TransitionTo(new Confirmed());
        }
    }
}
