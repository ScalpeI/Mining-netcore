using Microsoft.EntityFrameworkCore;
using MiningUpdate.Abstract;
using MiningUpdate.Model;
using System.Collections.Generic;

namespace MiningUpdate.Concrete
{
    public class EFRateRepository : IRateRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Rate> Rates
        {
            get { return context.Rates; }
            set { }
        }

        public void SaveRate(Rate rate)
        {
            context.Rates.Attach(rate);
            context.Entry(rate).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
