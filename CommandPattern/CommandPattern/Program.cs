using System;
using CommandPattern.Command;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = CommandFactory.GetCommand("Sum", 1, 1);
            sum.Execute();
            NewLine();
            var subtraction = CommandFactory.GetCommand("Subtraction", 5, 1);
            subtraction.Execute();
            NewLine();
            var multiplication = CommandFactory.GetCommand("Multiplication", 5, 1);
            multiplication.Execute();
            NewLine();
            var division = CommandFactory.GetCommand("Division", 5, 1);
            division.Execute();
            NewLine();
            var divisionBy0 = CommandFactory.GetCommand("Division", 5, 0);
            divisionBy0.Execute();
            NewLine();
            var notExistingCommand = CommandFactory.GetCommand("NotExisting", 5, 0);
            notExistingCommand.Execute();

            Console.ReadKey();

        }

        private static void NewLine() => Console.WriteLine();

    }
}
