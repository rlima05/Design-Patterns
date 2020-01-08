using DecoratorPattern.Decorator;
using static System.Console;


namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           var mathService = new MathService();
           var mathServiceDecorator = new MathServiceLoggingDecorator(mathService);

           //Example with no logging:
           var sum = mathService.Sum(1,2);
           WriteLine(sum);

           var divide = mathService.Divide(2, 1);
           WriteLine(divide);

            //Logging
           var sumLogged = mathServiceDecorator.Sum(1, 1);
           WriteLine(sumLogged);

            var dividedLogged = mathServiceDecorator.Divide(2, 1);
            WriteLine(dividedLogged);

            var dividedByZeroLogged = mathServiceDecorator.Divide(2, 0);
            WriteLine(dividedByZeroLogged);

            ReadKey();

        }
    }
}
