using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Context;

namespace StrategyPattern.Strategy.Travel
{
    public class FlightTravel : ITravelStrategy
    {
        public void Travel(Passenger passenger)
        {
            Console.WriteLine($"Passenger {passenger.Name} is flying to {passenger.Destination}");
        }
    }
}
