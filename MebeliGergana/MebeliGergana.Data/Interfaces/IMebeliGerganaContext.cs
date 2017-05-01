using System.Data.Entity;
using MebeliGergana.Models.EntityModels;

namespace MebeliGergana.Data.Interfaces
{
    public interface IMebeliGerganaContext
    {
        DbSet<Spalnq> Spalni { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Kuhnq> Kuhni { get; set; }
        DbSet<Masa> Masi { get; set; }
        DbSet<Portmanto> Portmanta { get; set; }
        DbSet<Sekciq> Sekcii { get; set; }
        DbSet<Detska> Detski { get; set; }
        DbSet<Porachka> Porachki { get; set; }
        int SaveChanges();
    }
}