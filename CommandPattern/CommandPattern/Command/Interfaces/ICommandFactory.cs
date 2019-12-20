using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Command.Interfaces
{
    public interface ICommandFactory
    {
        string CommandName { get; }
        ICommand MakeCommand(int a, int b);
    }
}
