using MiningUpdate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningUpdate.Abstract
{
    public interface IMinearRepository
    {
        IEnumerable<Minear> Minears { get; set; }
        void UpdateEar(string Jsonstring);
    }
}
