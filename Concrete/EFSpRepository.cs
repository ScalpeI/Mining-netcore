using MiningUpdate.Abstract;
using MiningUpdate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiningUpdate.Concrete
{
    public class EFSpRepository : ISpRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Sp> Sps
        {
            get { return context.Sps; }
            set { }
        }
        public void Create(string owner, double hash, string type)
        {
            if (context.Sps.Where(x => x.owner == owner && x.date == DateTime.Parse(DateTime.Now.ToUniversalTime().ToString("s").Substring(0, 17) + "00")).Count() == 0)
            {
                context.Sps.Add(new Sp { owner = owner, hash = hash, type = type, date = DateTime.Parse(DateTime.Now.ToUniversalTime().ToString("s").Substring(0, 17) + "00") });
                context.SaveChanges();
            }
        }
    }
}
