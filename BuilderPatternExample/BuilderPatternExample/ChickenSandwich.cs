namespace BuilderPatternExample
{
    public class ChickenSandwich : SandwichBuilder
    {
        public override void AddCheese()
        {
            sandwich.CheeseType = CheeseType.Swiss;
        }

        public override void AddMeat()
        {
            sandwich.MeatType = MeatType.Chicken;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
        }
    }
}
