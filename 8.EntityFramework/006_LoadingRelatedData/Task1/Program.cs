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

            //Eager loading
            ReadVehiclesWithBuyer();
            ReadBuyersWithVehicles();

            //Explicit loading
            ReadFirstBuyerInfo();
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

            dbContext.SaveChanges();
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
                Console.WriteLine($"Vehicle's name: {vehicle.Name}. Buyer's name: {vehicle.Buyer?.Name ?? "<null>"}.");
            }

            #region HelpfulCode
            //var vehiclesQueryable = dbContext
            //.Vehicles
            //.Where(x => x.Price > 7_000)
            //.OrderByDescending(x => x.Price);

            //var vehicles = vehiclesQueryable.ToList();

            //Console.WriteLine(new string('-', 80));

            //foreach (var vehicle in vehicles)
            //{
            //    Console.WriteLine(
            //        $"Vehicle name: {vehicle.Name}. " +
            //        $"Price : {vehicle.Price}$.");
            //}

            //var generatedSql = vehiclesQueryable.ToQueryString();
            //Console.WriteLine(generatedSql);


            //var cheapestVehicle = dbContext
            //    .Vehicles
            //    .OrderBy(x => x.Price)
            //    .FirstOrDefault();

            //Console.WriteLine(new string('-', 80));

            //Console.WriteLine(
            //    $"The cheapest vehicle name: {cheapestVehicle.Name}. " +
            //    $"The cheapest vehicle price: {cheapestVehicle.Price}$.");

            //var joinedVehiclesQuaryable =
            //    from vehicle in dbContext.Vehicles
            //    join buyer in dbContext.Buyers
            //        on vehicle.BuyerId equals buyer.Id into g
            //    from buyer in g.DefaultIfEmpty()
            //    select new { Vehicle = vehicle, Buyer = buyer };

            //var joinedVehicles = joinedVehiclesQuaryable.ToList();

            //Console.WriteLine(new string('-', 80));

            //foreach (var joinedVehicle in joinedVehicles)
            //{
            //    Console.WriteLine(
            //        $"Vehicle name: {joinedVehicle.Vehicle.Name}. " +
            //        $"Price: {joinedVehicle.Vehicle.Price}. " +
            //        $"Buyer name: {joinedVehicle.Buyer?.Name ?? "<null>"}.");
            //}
            #endregion

        }
        
        public static void ReadBuyersWithVehicles()
        {
            using var dbContext = new ApplicationDbContext();

            var buyersQueryable = dbContext
                .Buyers
                .Include(
                    x => x.Vehicles
                        .Where(x => x.Price > 5500m)
                        .OrderByDescending(x => x.Price));

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
        
        public static void ReadFirstBuyerInfo()
        {
            using var dbContext = new ApplicationDbContext();

            var firstBuyer = dbContext.Buyers.First();

            var firstBuyerVehiclesTotalAmount = dbContext
                .Entry(firstBuyer)
                .Collection(x => x.Vehicles)
                .Query()
                .Count();

            dbContext
                .Entry(firstBuyer)
                .Collection(x => x.Vehicles)
                .Load();

            Console.WriteLine(new string('-', 80));

                foreach (var vehicle in firstBuyer.Vehicles)
                {
                    Console.WriteLine($"Buyer's name: {firstBuyer.Name}. Vehicle's name: {vehicle.Name}. Vehicle's price: {vehicle.Price}.");
                }
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Buyer> Buyers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyEFCoreDb;Trusted_Connection=True;")
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
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

        public Buyer Buyer { get; set; }
    }

    public class Buyer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

