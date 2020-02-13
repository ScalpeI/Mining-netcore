using MiningUpdate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningUpdate.Abstract
{
    public interface IBtcRepository
    {
        IEnumerable<Btc> Btcs { get; set; }
        void Create(string owner, double hash, string type);
    }
}
