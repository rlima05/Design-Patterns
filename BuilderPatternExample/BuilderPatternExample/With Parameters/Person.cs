using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class Person
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public decimal AnnualIncome { get; set; }

        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} lives in {Street} with PostCode {PostCode} in the city {City}" +
                $" and works in {CompanyName} as a {Position} with {AnnualIncome} annual income");
        }
    }
}
