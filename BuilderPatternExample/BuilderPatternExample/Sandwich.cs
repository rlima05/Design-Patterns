using System;
using static System.Console;

namespace BuilderPatternExample
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public MeatType MeatType { get; set; }
        public CheeseType CheeseType { get; set; }
        public bool IsGrilled { get; set; }


        public void Display()
        {
            WriteLine($"Bread type: {BreadType}");
            WriteLine($"Meat type: {MeatType}");
            WriteLine($"Cheese type: {CheeseType}");
            if (IsGrilled) WriteLine("Grilled");
            else WriteLine("Not Grilled");
        }
    }

    public enum BreadType
    {
        White,
        Black
    }

    public enum MeatType
    {
        Turkey,
        Chicken,
        Bacon,
        Hamburguer
    }

    public enum CheeseType
    {
        Swiss,
        Gorgonzola,
        Mozzarella,
        Cheddar
    }
}
