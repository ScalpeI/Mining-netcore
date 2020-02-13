using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MiningUpdate.Model
{
    public class User
    {
        [Display(Name = "ID")]
        [Key]
        public int UserId { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Login")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Sail")]
        public string PasswordHash { get; set; }

        [Display(Name = "Key MMR")]
        public string Mkey { get; set; }

        [Display(Name = "Secret MMR")]
        public string Msecret { get; set; }

        [Display(Name = "Key BTC")]
        public string Bkey { get; set; }

        [Display(Name = "BTC puid")]
        public string Bpuid { get; set; }

        [Display(Name = "Token Spool")]
        public string Stoken { get; set; }

    }
}
