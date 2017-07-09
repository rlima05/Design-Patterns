using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public SandwichBuilder()
        {
            
        }

        public void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public abstract void PrepareBread();
        public abstract void AddMeat();
        public abstract void AddCheese();
    }
}
