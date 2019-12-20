using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Context;

namespace StrategyPattern.Strategy.Travel
{
    public class BusTravel : ITravelStrategy
    {
        public void Travel(Passenger passenger)
        {            
            Console.WriteLine($"Passenger {passenger.Name} is travelling to {passenger.Destination} by bus");
        }
    }
}
