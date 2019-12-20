using CommandPattern.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command.ConcreteCommands
{
    public abstract class AbstractCommand : ICommand, ICommandFactory
    {
        protected int A { get; set; }
        protected int B { get; set; }

        public string CommandName { get; protected set; }
        public abstract void Execute();

        public ICommand MakeCommand(int a, int b)       
        {
            A = a;
            B = b;

            return this;
        }
    }
}
