using MiningUpdate.Abstract;
using MiningUpdate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningUpdate.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<User> Users
        {
            get { return context.Users; }
            set { }
        }
    }
}
