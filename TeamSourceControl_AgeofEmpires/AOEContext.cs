using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl_AgeofEmpires
{
    class AOEContext : DbContext
    {
        public AOEContext() : base("AOEcontext")
        {
            Database.SetInitializer(new AOEDBInitializer()); //Seeds the database with default data (especially soldiers)
        }
        public DbSet<Army> Armies { get; set; }
        public DbSet<Soldier> Soldiers { get; set; }
    }
}
