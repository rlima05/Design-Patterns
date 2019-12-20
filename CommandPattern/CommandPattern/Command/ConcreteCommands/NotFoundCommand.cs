using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command.ConcreteCommands
{
    public class NotFoundCommand : AbstractCommand
    {
        public NotFoundCommand()
        {
            CommandName = "Not Found";
        }

        public override void Execute()
        {
            Console.WriteLine("Command not found");
        }
    }
}
