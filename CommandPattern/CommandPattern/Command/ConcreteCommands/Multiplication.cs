using System;

namespace CommandPattern.Command.ConcreteCommands
{
    public class Multiplication : AbstractCommand
    {
        public Multiplication()
        {
            CommandName = "Multiplication";
        }
        public override void Execute()
        {
            var result = A * B;

            Console.WriteLine($"The Multiplication of {A} and {B} is {result}");
        }
    }
}
