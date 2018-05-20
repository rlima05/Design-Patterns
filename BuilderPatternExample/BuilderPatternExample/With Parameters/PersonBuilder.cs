using System;

namespace BuilderPatternExample
{
    public class PersonBuilder
    {
        protected Person Person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(Person);

        public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);

        public PersonBuilder MyNameIs(string name)
        {
            Person.Name = name;
            return this;
        }

        public Person ToPerson()
        {
            return Person;
        }

        
    }
}
