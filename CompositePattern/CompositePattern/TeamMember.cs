using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public abstract class TeamMember
    {
        protected string Name;

        public TeamMember(string name)
        {
            Name = name;
        }
        public abstract void Display(int depth);
    }
}
