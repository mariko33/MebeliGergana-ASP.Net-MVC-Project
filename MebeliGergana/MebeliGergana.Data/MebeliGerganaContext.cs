using System.Data.Entity;
using MebeliGergana.Data.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MebeliGergana.Data
{
    using Models.EntityModels;

    public class MebeliGerganaContext : IdentityDbContext<ApplicationUser>, IMebeliGerganaContext
    {
       
        public MebeliGerganaContext()
            : base("MebeliGergana")
        {            
        }

        public DbSet<Spalnq> Spalni { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Kuhnq> Kuhni { get; set; }

        public DbSet<Masa> Masi { get; set; }
        public DbSet<Portmanto> Portmanta { get; set; }
        public DbSet<Sekciq> Sekcii { get; set; }
        public DbSet<Detska> Detski { get; set; }

        public DbSet<Porachka> Porachki { get; set; }

        public static MebeliGerganaContext Create()
        {
            return new MebeliGerganaContext();
        }

    }

   
}