using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }

        public void Display()
        {
            var properties = GetType().GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name} : {property.GetValue(this)}");
            }

            Console.WriteLine();

        }
    }
}
