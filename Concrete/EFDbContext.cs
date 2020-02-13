using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MiningUpdate.Model;
using System;
using System.Collections.Generic;

using System.Text;

namespace MiningUpdate.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<Mrr> Mrrs { get; set; }
        public DbSet<Sp> Sps { get; set; }
        public DbSet<Btc> Btcs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Minear> Minears { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Mining;Integrated Security=True;", builder =>
             {
                 builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(3), null);
             });
        }
    }
}
