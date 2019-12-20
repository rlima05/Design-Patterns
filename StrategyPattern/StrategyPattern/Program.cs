using System;
using StrategyPattern.Context;
using StrategyPattern.Strategy.Travel;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var passenger = new Passenger
            {
                Name = "Traveller",
                Destination = "Copenhagen"
            };

            passenger.Travel(new BusTravel());

            passenger.Destination = "Berlin";

            passenger.Travel(new FlightTravel());

            Console.ReadKey();
        }
    }
}
