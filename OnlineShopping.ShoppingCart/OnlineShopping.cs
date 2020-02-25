using OnlineShopping.Authentication;
using OnlineShopping.Orders;

namespace OnlineShopping.ShoppingCart
{
    public sealed class OnlineShopping : IOnlineShopping
    {
        private readonly IUserSession _userSession;
        private readonly IManageOrders _manageOrders;

        private OnlineShopping(IUserSession userSession, IManageOrders manageOrders)
        {
            _userSession = userSession;
            _manageOrders = manageOrders;
        }

        public static IOnlineShopping CreateInstance()
        {
            return new OnlineShopping(UserSession.CreateInstance(), ManageOrders.CreateInstance());
        }

        public static IOnlineShopping CreateInstance(IUserSession userSession, IManageOrders manageOrders)
        {
            return new OnlineShopping(userSession, manageOrders);
        }
    }
}
