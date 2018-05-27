using System;

namespace CompositePattern
{
    public abstract class AObject
    {

        protected string Name { get; set; }
        public int Level { get; set; }

        public AObject(string name)
        {
            Name = name;
            
        }

        public abstract void Display();
        
        protected string GetAlignment()
        {
            var alignment = string.Empty;

            alignment = alignment.PadLeft(Level, '\t');

            return alignment;
        }
    }
}
