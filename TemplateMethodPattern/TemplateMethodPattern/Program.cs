using static System.Console;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new BusTraveller();
            bus.Start();

            WriteLine();
            
            var flight = new FlightTraveller();
            flight.Start();

            ReadKey();
        }
    }
}
