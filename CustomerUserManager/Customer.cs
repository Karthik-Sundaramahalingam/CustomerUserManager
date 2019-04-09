using Microsoft.AspNet.Identity;
using System;

namespace Karthik.Marvel
{
    public class Customer : IUser<int>
    {
        public int Id => throw new NotImplementedException();

        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
