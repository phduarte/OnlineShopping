using System.Collections.Generic;

namespace OnlineShopping.Inventory
{
    public interface ISearchInventory
    {
        IEnumerable<Product> FindByName(string name);
    }
}
