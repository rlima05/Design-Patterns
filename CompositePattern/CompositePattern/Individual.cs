using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Individual : TeamMember
    {
        public Individual(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
