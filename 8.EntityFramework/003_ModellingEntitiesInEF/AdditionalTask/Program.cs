using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatingEmptyDatabase();
            CreatingView();
            AddingData();
            ReadingData();
        }

        public static void CreatingEmptyDatabase()
        {
            using var dbContext = new ApplicationDbContext();

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }

        public static void CreatingView()
        {
            using var dbContext = new ApplicationDbContext();

            var createViewCommand = $@"
            CREATE VIEW CompanyNames AS
                SELECT o.Name as Name
                FROM Organizations o
                WHERE o.Number < 10";

            dbContext.Database.ExecuteSqlRaw(createViewCommand);
        }

        public static void AddingData()
        {
            using var dbContext = new ApplicationDbContext();

            var company = new Company
            {
                Name = "Apple"
            };

            dbContext.Add(company);

            var companyFinancialInfo = new CompanyFinancialInfo
            {
                Expenditure = 10_000_000m,
                Revenue = 11_000_000m
            };

            dbContext.Add(companyFinancialInfo);
            dbContext.SaveChanges();
        }

        public static void ReadingData()
        {
            using var dbContext = new ApplicationDbContext();

            var companyName = dbContext.CompanyNames.First();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Information about the company");
            Console.WriteLine($"The company name is {companyName.Name}");
            Console.WriteLine(new string('-', 80));
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public DbSet<CompanyInfo> CompanyInfos { get; set; }

        public DbSet<CompanyName> CompanyNames { get; set; }

        public DbSet<CompanyGeoInfo> CompanyGeoInfos { get; set; }

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

            modelBuilder
                .Entity<Company>()
                .Property<DateTimeOffset>("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()")
                .ValueGeneratedOnAdd();

            const string companyCount = "CompanyCount";
            modelBuilder.HasSequence<int>(companyCount);

            modelBuilder
                .Entity<Company>()
                .Property(t => t.Number)
                .HasDefaultValueSql($"NEXT VALUE FOR [{companyCount}]");

            modelBuilder
                .Entity<Product>()
                .ToTable("Products");

            modelBuilder
                .Entity<FinancialProductInfo>()
                .ToTable("Products");

            modelBuilder
                .Entity<Product>()
                .HasOne(x => x.FinancialProductInfo)
                .WithOne()
                .HasForeignKey<FinancialProductInfo>(x => x.Id);

            modelBuilder
                .Entity<Product>()
                .Property(t => t.ProductName)
                .HasColumnName("ProductName");              
            
            modelBuilder
                .Entity<Product>()
                .Property(t => t.Version)
                .HasColumnName("Version");            
            
            modelBuilder
                .Entity<FinancialProductInfo>()
                .Property(t => t.ProductName)
                .HasColumnName("ProductName");            
            
            modelBuilder
                .Entity<FinancialProductInfo>()
                .Property(t => t.Version)
                .HasColumnName("Version");

            modelBuilder
                .Entity<CompanyName>()
                .HasNoKey();

            modelBuilder
                .Entity<CompanyName>()
                .ToView("CompanyNames");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }

    [Table("Organizations")]
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public int Number { get; set; }

        public ICollection<CompanyInfo> CompanyInfos { get; set; }

    }

    public class CompanyInfo
    {
        public int Id { get; set; }

        //public int CompanyFinancialInfoId { get; set; }

        public int CompanyGeoInfoId { get; set; }

        public Company Company { get; set; }

        public CompanyGeoInfo CompanyGeoInfo { get; set; }

        //public CompanyFinancialInfo CompanyFinancialInfo { get; set; }
    }

    public class CompanyGeoInfo
    {
        public int Id { get; set; }

        public int CompanyInfoId { get; set; }

        public CompanyInfo CompanyInfo { get; set; }
    }

    public class CompanyFinancialInfo
    {
        public int Id { get; set; }

        public decimal Expenditure { get; set; }

        public decimal Revenue { get; set; }

        public decimal NetIncome { get; set; }

        //public int CompanyInfoId { get; set; }

        //public CompanyInfo CompanyInfo { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Version { get; set; }

        public FinancialProductInfo FinancialProductInfo { get; set; }
    }

    public class FinancialProductInfo
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Version { get; set; }

        public decimal Price { get; set; }
    }

    public class CompanyName
    {
        public string Name { get; set; }
    }

    public class CompanyFinancialInfoEntityTypeConfiguration : IEntityTypeConfiguration<CompanyFinancialInfo>

    {
        public void Configure(EntityTypeBuilder<CompanyFinancialInfo> builder)
        {
            builder
                .ToTable("OrganizationFinancialInfo")
                .HasKey(x => x.Id);

            //builder
            //    .Property(x => x.CompanyInfoId)
            //    .HasColumnName("OrganizationInfoId");

            builder
                .Property<decimal>("NetIncome")
                .HasComputedColumnSql("[Revenue] - [Expenditure]", stored: true);
        }
    }
}


