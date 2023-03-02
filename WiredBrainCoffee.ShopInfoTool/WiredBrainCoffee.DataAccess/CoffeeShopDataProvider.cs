using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
          public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInkg = 107 };
            yield return new CoffeeShop { Location = "Freiburg", BeansInStockInkg = 23 };
            yield return new CoffeeShop { Location = "Munich", BeansInStockInkg = 56 };
        }
    }
}
