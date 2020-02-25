using OnlineShopping.Customers;

namespace OnlineShopping.Authentication
{
    public sealed class UserSession : IUserSession
    {
        readonly IManageCustomers _manageCustomers;

        private UserSession(IManageCustomers manageCustomers)
        {
            _manageCustomers = manageCustomers;
        }

        public static IUserSession CreateInstance()
        {
            return new UserSession(ManageCustomers.CreateInstance());
        }

        public static IUserSession CreateInstance(IManageCustomers manageCustomers)
        {
            return new UserSession(manageCustomers);
        }
    }
}
