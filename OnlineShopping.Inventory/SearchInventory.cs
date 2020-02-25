using System.Collections.Generic;
using System.Linq;

namespace OnlineShopping.Inventory
{
    public sealed class SearchInventory : ISearchInventory
    {
        Warehouse warehouse = new Warehouse();

        private SearchInventory()
        {

        }

        public IEnumerable<Product> FindByName(string name)
        {
            return warehouse.Products.Where(x => x.Nome.Contains(name));
        }

        public static ISearchInventory CreateInstance()
        {
            return new SearchInventory();
        }
    }
}
