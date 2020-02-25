namespace OnlineShopping.Accounts
{
    public sealed class ManageAccounts : IManageAccounts
    {
        public static IManageAccounts CreateInstance()
        {
            return new ManageAccounts();
        }
    }
}
