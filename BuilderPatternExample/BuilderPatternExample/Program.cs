using static System.Console;

namespace BuilderPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var maker = new SandwichMaker(new Hamburguer());
            maker.BuildSandwich();
            var sandwich = maker.GetSandwich();
            sandwich.Display();

            WriteLine();

            var maker2 = new SandwichMaker(new BaconSandwich());
            maker2.BuildSandwich();
            var sandwich2 = maker2.GetSandwich();
            sandwich2.Display();

            WriteLine();

            var maker3 = new SandwichMaker(new ChickenSandwich());
            maker3.BuildSandwich();
            var sandwich3 = maker3.GetSandwich();
            sandwich3.Display();

            WriteLine();

            ReadKey();
        }
    }
}
