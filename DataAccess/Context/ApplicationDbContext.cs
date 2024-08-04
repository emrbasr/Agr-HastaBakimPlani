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

           


        }
    }
}
