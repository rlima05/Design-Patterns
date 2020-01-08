using DecoratorPattern.Decorator;

namespace DecoratorPattern
{
    public class MathService : IMathService
    {
        public int Divide(int x, int y)
        {
            return x / y;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
