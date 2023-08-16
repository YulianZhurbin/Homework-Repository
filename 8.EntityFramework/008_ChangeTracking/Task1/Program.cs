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
            CreateEmptyDatabase();
            AddData();

            //ReadBuyersWithVehicles();
            //ReadVehiclesWithBuyer();

            //AddRelatedEntity();
            //UpdateEntityInContext();
            //UpdateRelatedEntity();
            //UpdateEntityPartially();
            //UpdateEntityFully();
            //DeleteCascade();
            //DeleteEntityInContext();
            DeleteEntityOutOfContext();

            //ReadBuyersWithVehicles();
            //ReadVehiclesWithBuyer();
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

            #region Vehicles

            var car1 = new Vehicle
            {
                Name = "Car1",
                Price = 5000
            };

            var car2 = new Vehicle
            {
                Name = "Car2",
                Price = 6000
            };

            var helicopter1 = new Vehicle
            {
                Name = "Helicopter1",
                Price = 70_000
            };

            var helicopter2 = new Vehicle
            {
                Name = "Helicopter2",
                Price = 80_000
            };

            var ship1 = new Vehicle
            {
                Name = "Ship1",
                Price = 50_000
            };

            #endregion

            #region Buyers

            var john = new Buyer
            {
                Name = "John"
            };

            var bob = new Buyer
            {
                Name = "Bob"
            };

            #endregion

            car1.Buyer = john;
            ship1.Buyer = john;

            car2.Buyer = bob;

            helicopter2.Buyer = bob;

            dbContext.Add(car1);
            dbContext.Add(car2);
            dbContext.Add(helicopter1);
            dbContext.Add(helicopter2);
            dbContext.Add(ship1);

            //Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.SaveChanges();

            //Console.WriteLine(new string('-', 80));
            //Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);
        }

        public static void ReadBuyersWithVehicles()
        {
            using var dbContext = new ApplicationDbContext();

            var buyersQueryable = dbContext
                .Buyers
                .Include(
                    x => x.Vehicles);

            var buyers = buyersQueryable.ToList();

            Console.WriteLine(new string('-', 80));

            foreach (var buyer in buyers)
            {
                foreach (var vehicle in buyer.Vehicles)
                {
                    Console.WriteLine($"Buyer's name: {buyer.Name}. Vehicle's name: {vehicle.Name}. Vehicle's price: {vehicle.Price}.");
                }
            }
        }

        public static void ReadVehiclesWithBuyer()
        {
            using var dbContext = new ApplicationDbContext();

            var vehiclesQueryable = dbContext
                .Vehicles
                .Include(
                    x => x.Buyer);

            var vehicles = vehiclesQueryable.ToList();

            Console.WriteLine(new string('-', 80));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle's name: {vehicle.Name}. Vehicle's price: {vehicle.Price}. Buyer's name: {vehicle.Buyer?.Name ?? "<null>"}. ");
            }
        }

        public static void AddRelatedEntity()
        {
            using var dbContext = new ApplicationDbContext();

            var ship2 = new Vehicle
            {
                Name = "Ship2",
                Price = 60_000
            };
            
            Console.WriteLine(new string('-', 80));

            Console.WriteLine(
                dbContext.ChangeTracker.DebugView.LongView == ""
                ? "Context is empty."
                : dbContext.ChangeTracker.DebugView.LongView);


            var buyer = dbContext
                .Buyers
                .Include(x => x.Vehicles)
                .Single(x => x.Name == "Bob");

            //var buyer = dbContext
            //    .Buyers
            //    .Include(x => x.Vehicles)
            //    .AsNoTracking()
            //    .Single(x => x.Name == "Bob");

            buyer.Vehicles.Add(ship2);

            //dbContext.ChangeTracker.DetectChanges();

            Console.WriteLine(new string('-', 80));

            Console.WriteLine(
                dbContext.ChangeTracker.DebugView.LongView == ""
                ? "Context is empty."
                : dbContext.ChangeTracker.DebugView.LongView);


            dbContext.SaveChanges();


            Console.WriteLine(new string('-', 80));

            Console.WriteLine(
                dbContext.ChangeTracker.DebugView.LongView == ""
                ? "Context is empty."
                : dbContext.ChangeTracker.DebugView.LongView);
        }

        public static void UpdateEntityInContext()
        {
            using var dbContext = new ApplicationDbContext();

            var buyer = dbContext
                .Buyers
                .Single(x => x.Name == "John");

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            buyer.Name = "Alan";

            //dbContext.ChangeTracker.DetectChanges();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.SaveChanges();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);
        }

        public static void UpdateRelatedEntity()
        {
            using var dbContext = new ApplicationDbContext();

            var buyer = dbContext
                .Buyers
                .Single(x => x.Name == "John");

            var vehicles = dbContext
                .Vehicles
                .Include(x => x.Buyer)
                .ToList();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            foreach (var vehicle in vehicles)
            {
                vehicle.Buyer = buyer;
            }

            //dbContext.ChangeTracker.DetectChanges();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.SaveChanges();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);
        }

        public static void UpdateEntityPartially()
        {
            using var dbContext = new ApplicationDbContext();

            var buyer = new Buyer
            {
                Id = 1,
                Name = "Steph"
            };

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.Buyers.Attach(buyer);
            dbContext.Entry(buyer).Property(t => t.Name).IsModified = true;

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.SaveChanges();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);
        }

        public static void UpdateEntityFully()
        {
            using var dbContext = new ApplicationDbContext();

            var vehicle = new Vehicle
            {
                Id = 2,
                Name = "Bicycle1",
                Price = 500
            };

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.Update(vehicle);

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.SaveChanges();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);
        }

        public static void DeleteCascade()
        {
            //Previously change BuyerId into required and remove adding helicopter1 to the database;

            using var dbContext = new ApplicationDbContext();

            var john = dbContext
                .Buyers
                .Single(x => x.Name == "John");

            dbContext.Remove(john);

            dbContext.SaveChanges();
        }

        public static void DeleteEntityInContext()
        {
            using var dbContext = new ApplicationDbContext();

            var firstVehicle = dbContext
                .Vehicles
                .First();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.Remove(firstVehicle);

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.SaveChanges();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);
        }

        public static void DeleteEntityOutOfContext()
        {
            using var dbContext = new ApplicationDbContext();

            var firstVehicle = new Vehicle
            {
                Id = 1
            };

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.Remove(firstVehicle);

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

            dbContext.SaveChanges();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);
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
                //.EnableDetailedErrors()
                //.EnableSensitiveDataLogging()
                //.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Buyer>()
                .HasMany(t => t.Vehicles)
                .WithOne(t => t.Buyer)
                .HasForeignKey(t => t.BuyerId)
                .HasPrincipalKey(t => t.Id);
        }
    }

    public class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? BuyerId { get; set; }
        //public int BuyerId { get; set; }

        public Buyer Buyer { get; set; }
    }

    public class Buyer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}


