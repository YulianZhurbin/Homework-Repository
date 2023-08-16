using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new ApplicationDbContext();

            dbContext.Database.Migrate();
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Buyer> Buyers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyEFCoreDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Buyer>()
                .HasMany(t => t.Vehicles)
                .WithOne(t => t.Buyer)
                .HasForeignKey(t => t.BuyerId)
                .HasPrincipalKey(t => t.Id);

            #region Vehicles

            var car1 = new Vehicle
            {
                Id = 1,
                Name = "Car1",
                Price = 5000,
                BuyerId = 1
            };

            var car2 = new Vehicle
            {
                Id = 2,
                Name = "Car2",
                Price = 6000,
                BuyerId = 2
            };

            var helicopter1 = new Vehicle
            {
                Id = 3,
                Name = "Helicopter1",
                Price = 70_000,
                BuyerId = 1
            };

            var helicopter2 = new Vehicle
            {
                Id = 4,
                Name = "Helicopter2",
                Price = 80_000,
                BuyerId = 2
            };

            var ship1 = new Vehicle
            {
                Id = 5,
                Name = "Ship1",
                Price = 50_000
            };

            #endregion

            #region Buyers

            var john = new Buyer
            {
                Id = 1,
                Name = "John"
            };

            var bob = new Buyer
            {
                Id = 2,
                Name = "Bob"
            };

            #endregion

            //car1.Buyer = john;
            //ship1.Buyer = john;

            //car2.Buyer = bob;

            //helicopter2.Buyer = bob;

            modelBuilder
                .Entity<Vehicle>()
                .HasData(car1, car2, helicopter1, helicopter2, ship1);

            modelBuilder
                .Entity<Buyer>()
                .HasData(john, bob);
        }
    }
    public class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? BuyerId { get; set; }

        public Buyer Buyer { get; set; }
    }

    public class Buyer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

