using MiningUpdate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningUpdate.Abstract
{
    public interface IRateRepository
    {
        IEnumerable<Rate> Rates { get; set; }
        void SaveRate(Rate rate);
    }
}
