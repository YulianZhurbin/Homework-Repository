using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatingEmptyDatabase();
        }

        public static void CreatingEmptyDatabase()
        {
            using var dbContext = new ApplicationDbContext();

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public DbSet<CompanyInfo> CompanyInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyEFCoreDb;Trusted_Connection=True;")
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<CompanyGeoInfo>()
                .HasOne(t => t.CompanyInfo)
                .WithOne(t => t.CompanyGeoInfo)
                .HasForeignKey<CompanyGeoInfo>(t => t.CompanyInfoId);
        }
    }

    [Table("Organizations")]
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<CompanyInfo> CompanyInfos { get; set; }
    }

    public class CompanyInfo
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int CompanyGeoInfoId { get; set; }

        public Company Company { get; set; }

        public CompanyGeoInfo CompanyGeoInfo { get; set;}
    }

    public class CompanyGeoInfo
    {
        public int Id { get; set; }

        public int CompanyInfoId { get; set; }

        public CompanyInfo CompanyInfo { get; set; }
    }
}

