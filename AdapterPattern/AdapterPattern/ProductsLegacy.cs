using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    //Simulation of an old/legacy API which cannot be changed
    public class ProductsLegacy
    {
        public List<string> GetAllProducts()
        {
            return new List<string>
            {
                "TV",
                "Videogame",
                "Phone"
            };
        }
    }
}
