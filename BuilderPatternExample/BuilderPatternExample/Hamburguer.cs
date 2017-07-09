using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class Hamburguer : SandwichBuilder
    {
        public override void AddCheese()
        {            
            sandwich.CheeseType = CheeseType.Cheddar;
        }

        public override void AddMeat()
        {
            sandwich.MeatType = MeatType.Hamburguer;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
        }
    }
}
