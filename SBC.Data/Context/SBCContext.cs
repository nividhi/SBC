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

    }
}
