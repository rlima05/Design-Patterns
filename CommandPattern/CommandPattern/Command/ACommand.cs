using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Command
{
    public abstract class ACommand
    {
        public abstract int Execute(int a, int b);
    }
}
