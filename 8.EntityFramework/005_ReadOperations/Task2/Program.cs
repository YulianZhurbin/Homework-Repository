using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateEmptyDatabase();
            AddData();
            ReadData();
        }

        public static void CreateEmptyDatabase()
        {
            using var dbContext = new ApplicationDbContext();

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            const string convertToEuroSql = @"
                CREATE FUNCTION dbo.ConvertToEuro(@dollarPrice DECIMAL(18,2))
                RETURNS DECIMAL(18,2)
                AS
                BEGIN
                    DECLARE @exchangeRate DECIMAL(18,2) = 0.91
                    RETURN @dollarPrice * @exchangeRate
                END";

            dbContext.Database.ExecuteSqlRaw(convertToEuroSql);
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

            dbContext.Add(car1);
            dbContext.Add(car2);
            dbContext.Add(helicopter1);
            dbContext.Add(ship1);

            dbContext.SaveChanges();
        }

        public static void ReadData()
        {
            using var dbContext = new ApplicationDbContext();

            var vehiclesTotalSum = dbContext
                 .Vehicles
                 .Sum(x => dbContext.ConvertToEuro(x.Price));

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Sum price of all vehicles: {vehiclesTotalSum} euro.");

            var joinedVehiclesQueryable = dbContext
                .Vehicles
                .Join(dbContext.Buyers,
                    x => x.BuyerId,
                    x => x.Id,
                    (vehicle, buyer) => new { Vehicle = vehicle, Buyer = buyer });

            var joinedVehicles = joinedVehiclesQueryable.ToList();

            Console.WriteLine(new string('-', 80));

            foreach(var joinedVehicle in joinedVehicles)
            {
                Console.WriteLine(
                    $"Vehicle name: {joinedVehicle.Vehicle.Name}. " +
                    $"Price: {joinedVehicle.Vehicle.Price}. " +
                    $"Buyer name: {joinedVehicle.Buyer.Name}.");
            }

            var groupedVehiclesQueryable = dbContext.Vehicles
                .GroupBy(x => x.BuyerId)
                .Select(
                x => new
                {
                    BuyerId = x.Key,
                    MoneySpent = x.Sum(y => y.Price)
                });

            var groupedVehicles = groupedVehiclesQueryable.ToList();

            Console.WriteLine(new string('-', 80));

            foreach (var groupedVehicle in groupedVehicles)
            {
                Console.WriteLine(
                    $"Buyer's id: {groupedVehicle.BuyerId}. " +
                    $"Money spent: {groupedVehicle.MoneySpent}");
            }
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Buyer> Buyers { get; set; }

        public decimal ConvertToEuro(decimal dollarPrice)
            => throw new NotSupportedException();

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

            modelBuilder
                .HasDbFunction(
                typeof(ApplicationDbContext).GetMethod(
                    nameof(ConvertToEuro), 
                    new[] { typeof(decimal) }))
                .HasName(nameof(ConvertToEuro));
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

