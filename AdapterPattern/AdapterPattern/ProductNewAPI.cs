using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{

    //Adapter class, adapting the new interface to the legacy API
    public class ProductNewAPI : IProduct
    {
        private readonly ProductsLegacy _productsLegacy;

        public ProductNewAPI(ProductsLegacy productsLegacy)
        {
            _productsLegacy = productsLegacy;
        }
        public List<string> GetProducts()
        {
            return _productsLegacy.GetAllProducts();
        }
    }
}
