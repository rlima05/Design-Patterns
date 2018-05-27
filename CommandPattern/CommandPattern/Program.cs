using CommandPattern.Command;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose you command, the available commands are add, sub, multi and division");
            var commandName = Console.ReadLine();
            Console.WriteLine("What is the first number?");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the secondo number?");
            var secondNumber = int.Parse(Console.ReadLine());

            var command = CommandFactory.GetCommand(commandName);

            var result = command.Execute(firstNumber, secondNumber);

            Console.WriteLine($"The final result is {result}");

            Console.ReadKey();

        }
    }
}
