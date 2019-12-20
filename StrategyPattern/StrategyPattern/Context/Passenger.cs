using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Strategy.Travel;

namespace StrategyPattern.Context
{
    public class Passenger 
    {
        public string Name { get; set; }
        public string Destination { get; set; }

        public void Travel(ITravelStrategy travelStrategy)
        {
            travelStrategy.Travel(this);
        }
    }
}
