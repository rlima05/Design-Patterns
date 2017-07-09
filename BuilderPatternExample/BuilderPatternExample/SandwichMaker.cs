using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder _sandwichBuilder;

        public SandwichMaker(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void BuildSandwich()
        {
            _sandwichBuilder.CreateNewSandwich();
            _sandwichBuilder.PrepareBread();
            _sandwichBuilder.AddMeat();
            _sandwichBuilder.AddCheese();
        }

        public Sandwich GetSandwich()
        {
            return _sandwichBuilder.GetSandwich();
        }
    }
}
