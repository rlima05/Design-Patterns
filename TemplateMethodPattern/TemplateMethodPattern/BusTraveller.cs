using static System.Console;

namespace TemplateMethodPattern
{
    public class BusTraveller : Traveller
    {
        protected override void SpecificActions()
        {
            WriteLine("Going to the bus station");
            WriteLine("Getting on the bus");
        }
    }
}
