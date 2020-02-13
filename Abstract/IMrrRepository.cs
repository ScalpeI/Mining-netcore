using MiningUpdate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningUpdate.Abstract
{
    public interface IMrrRepository
    {
        IEnumerable<Mrr> Mrrs { get; set; }

        void CreateMrr(int idrig, string owner, double hash, string type);
        void DeleteMrr(Mrr mrr);
    }
}
