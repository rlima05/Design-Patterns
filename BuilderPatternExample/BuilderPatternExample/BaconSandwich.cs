using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class BaconSandwich : SandwichBuilder
    {
        public override void AddCheese()
        {
            sandwich.CheeseType = CheeseType.Gorgonzola;            
        }

        public override void AddMeat()
        {
            sandwich.MeatType = MeatType.Bacon;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.Black;
            sandwich.IsGrilled = true;
        }
    }
}
