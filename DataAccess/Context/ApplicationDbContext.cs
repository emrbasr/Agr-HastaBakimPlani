using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<Hemsire> Hemsireler { get; set; }
        public DbSet<Girisim> Girisimler { get; set; }
        public DbSet<Sonuc> Sonuclar { get; set; }
        public DbSet<CheckboxItem> CheckboxItems { get; set; }
        public DbSet<AgriHastaBakimPlani> AgriHastaBakimPlanlari { get; set; }
        public DbSet<Neden> Nedenler { get; set; }
        public DbSet<TaniOlculeri> TaniOlculeriList { get; set; }
        public DbSet<Amac> Amaclar { get; set; }
        public DbSet<Degerlendirme> Degerlendirmeler { get; set; }
        public ApplicationDbContext()
        {
                
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=hastabakımDb;Trusted_Connection=True;");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AgriHastaBakimPlani>()
                .HasKey(a => a.Id); 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Girisim>()
            .HasOne(g => g.AgriHastaBakimPlani)
            .WithMany(p => p.Girisimler)
            .HasForeignKey(g => g.AgriHastaBakimPlaniId);


            modelBuilder.Entity<Neden>()
             .HasOne(n => n.AgriHastaBakimPlani)
             .WithMany(a => a.Nedenler)
             .HasForeignKey(n => n.AgriHastaBakimPlaniId);

            modelBuilder.Entity<TaniOlculeri>()
                .HasOne(t => t.AgriHastaBakimPlani)
                .WithMany(a => a.TaniOlculeriList)
                .HasForeignKey(t => t.AgriHastaBakimPlaniId);

            modelBuilder.Entity<Amac>()
                .HasOne(a => a.AgriHastaBakimPlani)
                .WithMany(p => p.Amaclar)
                .HasForeignKey(a => a.AgriHastaBakimPlaniId);

            modelBuilder.Entity<Degerlendirme>()
                .HasOne(d => d.Hasta)
                .WithMany(h => h.Degerlendirmeler)
                .HasForeignKey(d => d.HastaId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
