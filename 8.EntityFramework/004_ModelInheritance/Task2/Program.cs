using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Task2
{
    //TPT method
    class Program
    {
        static void Main(string[] args)
        {
            CreateEmptyDatabase();
            AddData();
        }

        public static void CreateEmptyDatabase()
        {
            using var dbContext = new ApplicationDbContext();

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }

        public static void AddData()
        {
            using var dbContext = new ApplicationDbContext();

            var fordFocus = new Automobile
            {
                Name = "Ford Focus",
                Speed = 220,
                WheelCount = 4
            };

            var cruiser46 = new Ship
            {
                Name = "Cruiser 46",
                Speed = 60,
                SailCount = 3
            };

            dbContext.Add(fordFocus);
            dbContext.Add(cruiser46);

            dbContext.SaveChanges();
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Automobile> Automobiles { get; set; }

        public DbSet<Ship> Ships { get; set; }

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
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
            modelBuilder.Entity<Automobile>().ToTable("Automobiles");
            modelBuilder.Entity<Ship>().ToTable("Ships");
        }
    }

    public abstract class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Speed { get; set; }
    }

    public class Automobile : Vehicle
    {
        public int WheelCount { get; set; }
    }

    public class Ship : Vehicle
    {
        public int SailCount { get; set; }
    }
}
