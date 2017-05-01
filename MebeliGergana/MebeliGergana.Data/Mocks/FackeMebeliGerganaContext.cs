using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebeliGergana.Data.Interfaces;
using MebeliGergana.Models.EntityModels;

namespace MebeliGergana.Data.Mocks
{
   public class FackeMebeliGerganaContext:IMebeliGerganaContext
    {
        public FackeMebeliGerganaContext()
        {
            this.Spalni=new FackeSpalniDbSet();
        }

        public DbSet<Spalnq> Spalni { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Kuhnq> Kuhni { get; set; }
        public DbSet<Masa> Masi { get; set; }
        public DbSet<Portmanto> Portmanta { get; set; }
        public DbSet<Sekciq> Sekcii { get; set; }
        public DbSet<Detska> Detski { get; set; }
        public DbSet<Porachka> Porachki { get; set; }
        public int SaveChanges()
        {
            return 0;
        }
    }
}
