using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Group : TeamMember
    {
        private List<TeamMember> _children = new List<TeamMember>();

        public Group(string name) : base(name)
        {
        }

        public void Add(TeamMember teamMember)
        {
            _children.Add(teamMember);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
            foreach (var children in _children)
            {
                children.Display(depth + 2);
            }

        }

        public void Remove(TeamMember teamMember)
        {
            _children.Remove(teamMember);
        }
    }
}
