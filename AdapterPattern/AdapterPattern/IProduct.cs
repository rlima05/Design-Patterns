using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    //New interface which needs to be adapted to the legacy API
    public interface IProduct
    {
        List<string> GetProducts();
    }
}
