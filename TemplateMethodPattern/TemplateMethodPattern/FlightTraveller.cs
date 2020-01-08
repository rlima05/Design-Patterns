using static System.Console;

namespace TemplateMethodPattern
{
    public class FlightTraveller : Traveller
    {
        protected override void SpecificActions()
        {
          WriteLine("Check in online");
          WriteLine("Going to the airport");
          WriteLine("Security check");
          WriteLine("Boarding");
          WriteLine("Flying to my destination");
        }
    }
}
