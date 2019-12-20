using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command.ConcreteCommands
{
    public class Division : AbstractCommand
    {
        public Division()
        {
            CommandName = "Division";
        }

        public override void Execute()
        {
            if (B == 0)
            {
                Console.WriteLine("Impossible to divide by 0.");
                return;
            }

            var result = A / B;

            Console.WriteLine($"The Division of {A} and {B} is {result}");
        }
    }
}
