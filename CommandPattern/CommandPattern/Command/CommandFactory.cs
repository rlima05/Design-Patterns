using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPattern.Command.ConcreteCommands;
using CommandPattern.Command.Interfaces;

namespace CommandPattern.Command
{
    public static class CommandFactory
    {
        private static readonly ICommandFactory[] _commandList =
        {
            new Sum(),
            new Subtraction(),
            new Multiplication(),
            new Division()
        };

        public static ICommand GetCommand(string name, int a, int b)
        {
            var command = _commandList.FirstOrDefault(c => c.CommandName == name);
            return command == null ? new NotFoundCommand() : command.MakeCommand(a, b);
        }
    }
}
