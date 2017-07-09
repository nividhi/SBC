using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = SBC.Data.Entities;

namespace SBC.Data.Context
{
    public class SBCContext : DbContext
    {
        public SBCContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Entity.Type> Types { get; set; }
        public DbSet<Entity.Purity> Purities { get; set; }

        public DbSet<Entity.Product> Products { get; set; }

        public DbSet<Entity.Item> Items { get; set; }

        public DbSet<Entity.Country> Countries { get; set; }

        public DbSet<Entity.State> States { get; set; }

        public DbSet<Entity.City> Cities { get; set; }

        public DbSet<Entity.AccountType> AccountTypes { get; set; }

        public DbSet<Entity.Account> Accounts { get; set; }



    }
}
