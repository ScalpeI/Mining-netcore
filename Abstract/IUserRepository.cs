using MiningUpdate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningUpdate.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; set; }
    }
}
