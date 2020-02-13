using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MiningUpdate.Model
{
    public class Minear
    {
        [Key]
        public int id { get; set; }
        public string mining_earnings { get; set; }
        public string fpps_mining_earnings { get; set; }
    }
}
