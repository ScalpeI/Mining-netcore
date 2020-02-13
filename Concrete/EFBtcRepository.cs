using MiningUpdate.Abstract;
using MiningUpdate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiningUpdate.Concrete
{
    public class EFBtcRepository : IBtcRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Btc> Btcs
        {
            get { return context.Btcs; }
            set { }
        }

        public void Create(string owner, double hash, string type)
        {
                context.Btcs.Add(new Btc { owner = owner, hash = hash, type = type, date = DateTime.Parse(DateTime.Now.ToUniversalTime().ToString("s").Substring(0, 17) + "00") });
                context.SaveChanges();
        }
    }
}
