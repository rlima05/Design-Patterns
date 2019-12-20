using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public abstract class OrderState
    {
        public abstract void CheckOrder(Order order);
    }
}
