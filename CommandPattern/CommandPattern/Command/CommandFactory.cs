using System.Collections.Generic;
using System.Linq;

namespace CommandPattern.Command
{
    public static class CommandFactory
    {
        private static Dictionary<string, ACommand> Commands => new Dictionary<string, ACommand>
                                                        {
                                                            {"add", new AdditionCommand() },
                                                            {"sub", new SubstractionCommand() },
                                                            {"multi", new MultiplicationCommand() } ,
                                                            {"division", new DivisionCommand() }
                                                        };

        public static ACommand GetCommand(string command)
        {
            return Commands.FirstOrDefault(c => c.Key.Equals(command, System.StringComparison.InvariantCultureIgnoreCase)).Value;
        }

    }
}
