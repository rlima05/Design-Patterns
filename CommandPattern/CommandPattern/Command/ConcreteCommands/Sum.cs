using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Command.Interfaces;

namespace CommandPattern.Command.ConcreteCommands
{
    public class Sum : AbstractCommand
    {
        public Sum()
        {
            CommandName = "Sum";
        }
        public override void Execute()
        {
            var result = A + B;

            Console.WriteLine($"The sum of {A} and {B} is {result}");
        }

    }
}
