using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class BaseDbContext : DbContext
    {
        public DbSet<BrandCategories> BrandCategories { get; set; }

        public DbSet<Brands> Brands { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Payments> Payments { get; set; }

        public DbSet<PaymentTypes> PaymentTypes { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMET\\SQLEXPRESS; Database=Tobeto290324Odev; Encrypt = False");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandCategories>().HasKey(bc => bc.Id);
            modelBuilder.Entity<BrandCategories>().Property(bc => bc.Id).UseIdentityColumn();
            modelBuilder.Entity<BrandCategories>().Property(bc => bc.Description).IsRequired(false);
            modelBuilder.Entity<BrandCategories>().Property(bc => bc.Description).HasMaxLength(200);
            modelBuilder.Entity<BrandCategories>().HasOne(bc => bc.Brands);
            modelBuilder.Entity<BrandCategories>().HasOne(bc => bc.Categories);

            modelBuilder.Entity<Brands>().HasKey(b => b.Id);
            modelBuilder.Entity<Brands>().Property(b => b.Id).UseIdentityColumn();
            modelBuilder.Entity<Brands>().Property(b => b.Description).IsRequired(false);
            modelBuilder.Entity<Brands>().Property(b => b.Description).HasMaxLength(200);

            modelBuilder.Entity<Categories>().HasKey(c => c.Id);
            modelBuilder.Entity<Categories>().Property(c => c.Id).UseIdentityColumn();
            modelBuilder.Entity<Categories>().Property(c => c.Description).IsRequired(false);
            modelBuilder.Entity<Categories>().Property(c => c.Description).HasMaxLength(200);

            modelBuilder.Entity<Orders>().HasKey(o => o.Id);
            modelBuilder.Entity<Orders>().Property(o => o.Id).UseIdentityColumn();
            modelBuilder.Entity<Orders>().Property(o => o.StartDate).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Orders>().Property(o => o.EndDate).IsRequired(false);

            modelBuilder.Entity<Payments>().HasKey(p => p.Id);
            modelBuilder.Entity<Payments>().Property(p => p.Id).UseIdentityColumn();
            modelBuilder.Entity<Payments>().HasOne(p => p.PaymentTypes);

            modelBuilder.Entity<PaymentTypes>().HasKey(pt => pt.Id);
            modelBuilder.Entity<PaymentTypes>().Property(pt => pt.Id).UseIdentityColumn();

            modelBuilder.Entity<Products>().HasKey(p => p.Id);
            modelBuilder.Entity<Products>().Property(p => p.Id).UseIdentityColumn();
            modelBuilder.Entity<Products>().Property(p => p.Description).IsRequired(false);
            modelBuilder.Entity<Products>().Property(p => p.Description).HasMaxLength(200);
            modelBuilder.Entity<Products>().HasOne(p => p.Categories);

            modelBuilder.Entity<Users>().HasKey(u => u.Id);
            modelBuilder.Entity<Users>().Property(u => u.Id).UseIdentityColumn();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
