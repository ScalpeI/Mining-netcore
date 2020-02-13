using MiningUpdate.Abstract;
using MiningUpdate.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningUpdate.Concrete
{
    public class EFMinearRepository : IMinearRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Minear> Minears
        {
            get { return context.Minears; }
            set { }
        }
        public void UpdateEar(string Jsonstring)
        {
            try
            {
                JObject obj = JObject.Parse(Jsonstring);
                dynamic jsonDe = JsonConvert.DeserializeObject(obj["data"].ToString());
                context.Minears.Add(new Minear { mining_earnings = "", fpps_mining_earnings = "0.0000" + jsonDe["amount_standard_earn"].ToString() });
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now.ToString() + " " + ex);
            }
        }
    }
}
