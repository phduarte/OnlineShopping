using OnlineShopping.Inventory;

namespace OnlineShopping.SearchEngine
{
    public sealed class ProductSearch : IProductSearch
    {
        private IManageInventory _manageInventory;

        private ProductSearch(IManageInventory manageInventory)
        {
            _manageInventory = manageInventory;
        }

        public static IProductSearch CreateInstance()
        {
            return new ProductSearch(ManageInventory.CreateInstance());
        }

        public static IProductSearch CreateInstance(IManageInventory manageInventory)
        {
            return new ProductSearch(manageInventory);
        }
    }
}
