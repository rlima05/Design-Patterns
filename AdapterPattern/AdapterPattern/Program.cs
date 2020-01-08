using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           IProduct product = new ProductNewAPI(new ProductsLegacy());

           var productList = product.GetProducts();

           productList.ForEach(c => Console.WriteLine(c));

           Console.ReadKey();
        }
    }
}
