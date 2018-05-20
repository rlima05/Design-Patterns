using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class PersonAddressBuilder  : PersonBuilder
    {
        public PersonAddressBuilder (Person person)
        {
            Person = person;
        }

        public PersonAddressBuilder At(string street)
        {
            Person.Street = street;
            return this;
        }

        public PersonAddressBuilder WithPostalCode(string postCode)
        {
            Person.PostCode = postCode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            Person.City = city;
            return this;
        }
    }
}
