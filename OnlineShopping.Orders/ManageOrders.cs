using OnlineShopping.Customers;
using OnlineShopping.Inventory;

namespace OnlineShopping.Orders
{
    public sealed class ManageOrders : IManageOrders
    {
        readonly IManageInventory _manageInventory;
        readonly IManageCustomers _manageCustomers;

        private ManageOrders(IManageInventory manageInventory, IManageCustomers manageCustomers)
        {
            _manageInventory = manageInventory;
            _manageCustomers = manageCustomers;
        }

        public static IManageOrders CreateInstance()
        {
            return new ManageOrders(ManageInventory.CreateInstance(), ManageCustomers.CreateInstance());
        }

        public static IManageOrders CreateInstance(IManageInventory manageInventory, IManageCustomers manageCustomers)
        {
            return new ManageOrders(manageInventory, manageCustomers);
        }
    }
}
