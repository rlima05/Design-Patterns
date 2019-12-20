using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Context;

namespace StrategyPattern.Strategy.Travel
{
    public interface ITravelStrategy
    {
        void Travel(Passenger passenger);
    }
}
