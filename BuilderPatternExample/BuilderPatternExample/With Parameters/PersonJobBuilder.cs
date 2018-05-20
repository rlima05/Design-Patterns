using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            Person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            Person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            Person.Position = position;
            return this;
        }

        public PersonJobBuilder WithIncome(decimal income)
        {
            Person.AnnualIncome = income;
            return this;
        }
    }
}
