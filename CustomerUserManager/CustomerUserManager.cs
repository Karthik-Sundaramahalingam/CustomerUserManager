using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
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
