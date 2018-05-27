using System;

namespace CompositePattern
{
    public class File : AObject
    {
        public File(string name) : base(name)
        {
        }

        public override void Display()
        {
            var alignment = GetAlignment();

            Console.WriteLine(string.Concat(alignment, Name));
        }
    }
}
