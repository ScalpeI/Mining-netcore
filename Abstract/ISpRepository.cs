using MiningUpdate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningUpdate.Abstract
{
    public interface ISpRepository
    {
        IEnumerable<Sp> Sps { get; set; }

        void Create(string owner, double hash, string type);
    }
}
