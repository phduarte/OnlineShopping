using OnlineShopping.Accounts;

namespace OnlineShopping.Customers
{
    public sealed class ManageCustomers : IManageCustomers
    {
        readonly IManageAccounts _manageAccounts;

        private ManageCustomers(IManageAccounts manageAccounts)
        {
            _manageAccounts = manageAccounts;
        }

        public static IManageCustomers CreateInstance()
        {
            return new ManageCustomers(ManageAccounts.CreateInstance());
        }

        public static IManageCustomers CreateInstance(IManageAccounts manageAccounts)
        {
            return new ManageCustomers(manageAccounts);
        }
    }
}
