using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command.ConcreteCommands
{
    public class Subtraction : AbstractCommand
    {
        public Subtraction()
        {
            CommandName = "Subtraction";
        }

           public override void Execute()
        {
            var result = A - B;

            Console.WriteLine($"The Subtraction of {A} and {B} is {result}");
        }

  
    }
}
