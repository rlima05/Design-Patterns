using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Folder : AObject
    {
        private List<AObject> Objects = new List<AObject>();

        public Folder(string name) : base(name)
        {
        }

        public void AddObject(AObject @object)
        {
            @object.Level = Level + 1;
            Objects.Add(@object);
        }

        public override void Display()
        {
            var alignment = GetAlignment();

            Console.WriteLine(string.Concat(alignment, Name));

            foreach (var @object in Objects)
            {
                @object.Display();
            }
        }
     
    }
}
