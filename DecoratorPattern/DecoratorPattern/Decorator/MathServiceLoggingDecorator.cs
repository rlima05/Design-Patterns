using static System.Console;
namespace DecoratorPattern.Decorator
{
    public class MathServiceLoggingDecorator : IMathService
    {
        private IMathService _mathService;
        public MathServiceLoggingDecorator(IMathService mathService)
        {
            _mathService = mathService;
        }

        public int Divide(int x, int y)
        {
            WriteLine($"Dividing {x} by {y}");

            if (y == 0)
            {
                WriteLine("It is not possible to divide by 0");
                return 0;
            }

            return _mathService.Divide(x, y);
        }

        public int Sum(int x, int y)
        {
            WriteLine($"Summing {x} and {y}");
            return _mathService.Sum(x, y);
        }
    }
}
