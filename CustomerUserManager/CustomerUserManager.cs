using Microsoft.AspNet.Identity;

namespace Karthik.Marvel
{
    public class CustomerUserManager : UserManager<Customer, int>
    {
        public CustomerUserManager(IUserStore<Customer, int> store) : base(store)
        {
        }
    }
}
