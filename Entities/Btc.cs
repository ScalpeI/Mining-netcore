using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MiningUpdate.Model
{
    public class Btc
    {
        [Key]
        public int id { get; set; }
        public string owner { get; set; }
        public double hash { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
    }
}
