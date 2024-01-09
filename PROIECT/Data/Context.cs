using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROIECT.Models;

namespace PROIECT.Data
{
    public class Context: IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public DbSet<Statiune> Statiuni { get; set; }
        public DbSet<Partie> Partii { get; set; }
        public DbSet<Angajat> Angajati { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Magazin> Magazine { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<UserProdus> UserProduse { get; set; }
        public DbSet<MagazinProdus> MagazinProduse { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Angajat>()
                .HasOne(a => a.Magazin)
                .WithMany(a => a.Angajati)
                .HasForeignKey(a => a.MagazinID);

            modelBuilder.Entity<Magazin>()
                .HasOne(m => m.Statiune)
                .WithMany(m => m.Magazine)
                .HasForeignKey(m => m.StatiuneID);

            modelBuilder.Entity<Partie>()
                .HasOne(p => p.Statiune)
                .WithMany(p => p.Partii)
                .HasForeignKey(p => p.StatiuneID);

            modelBuilder.Entity<MagazinProdus>()
                .HasOne(p => p.Produs)
                .WithMany(p => p.MagazinProduse)
                .HasForeignKey(p => p.ProdusID);

            modelBuilder.Entity<MagazinProdus>()
                .HasOne(m => m.Magazin)
                .WithMany(m => m.MagazinProduse)
                .HasForeignKey(m => m.MagazinID);

            modelBuilder.Entity<UserProdus>()
                .HasOne(p => p.Produs)
                .WithMany(p => p.UserProduse)
                .HasForeignKey(p => p.ProdusID);

            modelBuilder.Entity<UserProdus>()
                .HasOne(u => u.User)
                .WithMany(u => u.UserProduse)
                .HasForeignKey(u => u.UserID);
        }
    }
}
