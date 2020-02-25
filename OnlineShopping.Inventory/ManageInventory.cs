namespace OnlineShopping.Inventory
{
    public sealed class ManageInventory : IManageInventory
    {
        readonly Warehouse warehouse;
        
        private ManageInventory()
        {
            warehouse = new Warehouse();
            warehouse.OnProductAdded += Warehouse_OnProductAdded;
            warehouse.OnProductRemoved += Warehouse_OnProductRemoved;
        }

        private void Warehouse_OnProductRemoved(object sender, ProductRemovedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Warehouse_OnProductAdded(object sender, ProductAddedEventArgs e)
        {
            
        }

        public void AddProduct(int productId, int quantity)
        {
            warehouse.Add(productId, quantity);
        }

        public void RemoveProduct(int productId, int quantity)
        {
            warehouse.Remove(productId, quantity);
        }

        public static IManageInventory CreateInstance()
        {
            return new ManageInventory();
        }
    }
}