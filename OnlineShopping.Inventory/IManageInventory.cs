namespace OnlineShopping.Inventory
{
    public interface IManageInventory
    {
        void AddProduct(int productId, int quantity);
        void RemoveProduct(int productId, int quantity);
    }
}
