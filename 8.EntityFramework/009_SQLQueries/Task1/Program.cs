using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
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

            ReadUsingSql();
            //ReadFromTableValuedFunction();
            //ReadFromStoredProcedure();
            //UseToSqlQuery();
            //UseToFunction();

        }

        public static void CreateEmptyDatabase()
        {
            using var dbContext = new ApplicationDbContext();

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            var createSql = @"
                create function [dbo].[SearchVehicleByPrice] (@price decimal)
                returns table
                as
                return
                    select * from dbo.Vehicles
                    where Price = @price
            ";

            dbContext.Database.ExecuteSqlRaw(createSql);

            var createStoredProcedureSql = @"
                create procedure [dbo].[GetVehicleByName] @vehicleName nvarchar(max) as
                begin
                    select Vehicles.Id, Vehicles.Name, Vehicles.Price, Vehicles.BuyerId from dbo.[Vehicles]
                    where [Vehicles].Name = @vehicleName
                end
            ";

            dbContext.Database.ExecuteSqlRaw(createStoredProcedureSql);

            var createTableValuedFunction = @"
                create function [dbo].[GetVehicleWithPriceLessThan20000] ()
                returns table 
                as 
                return
                    select * from dbo.Vehicles
                    where Price < 20000
            ";

            dbContext.Database.ExecuteSqlRaw(createTableValuedFunction);
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

        public static void ReadUsingSql()
        {
            using var dbContext = new ApplicationDbContext();

            var buyersQueryable = dbContext
                .Buyers
                .FromSqlRaw("SELECT * FROM dbo.Buyers")
                .Include(x => x.Vehicles)
                .Where(x => x.Vehicles.Any(y => y.Price > 75_000));

            var buyers = buyersQueryable.ToList();

            Console.WriteLine(new string('-', 80));

            foreach (var buyer in buyers)
            {
                foreach (var vehicle in buyer.Vehicles)
                {
                    Console.WriteLine($"Buyer's name: {buyer.Name}. Vehicle's name: {vehicle.Name}. Vehicle's price: {vehicle.Price}.");
                }
            }

            var generatedSql = buyersQueryable.ToQueryString();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Generated sql query:");
            Console.WriteLine(generatedSql);
        }

        public static void ReadFromTableValuedFunction()
        {
            using var dbContext = new ApplicationDbContext();

            var vehiclesQueryable = dbContext
                .Vehicles
                .FromSqlRaw("SELECT * FROM dbo.SearchVehicleByPrice(5000)")
                .Include(x => x.Buyer);

            var vehicles = vehiclesQueryable.ToList();

            Console.WriteLine(new string('-', 80));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle's name: {vehicle.Name}. Vehicle's price: {vehicle.Price}. Buyer's name: {vehicle.Buyer?.Name ?? "<null>"}. ");
            }

            var generatedSql = vehiclesQueryable.ToQueryString();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Generated sql query:");
            Console.WriteLine(generatedSql);
        }
        
        public static void ReadFromStoredProcedure()
        {
            using var dbContext = new ApplicationDbContext();

            var car1Name = new SqlParameter("@vehicleName", "Car1");

            var vehiclesQueryable = dbContext
                .Vehicles
                .FromSqlRaw("EXECUTE dbo.GetVehicleByName @vehicleName", car1Name);

            var vehicles = vehiclesQueryable.ToList();

            Console.WriteLine(new string('-', 80));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle's name: {vehicle.Name}. Vehicle's price: {vehicle.Price}. Buyer's name: {vehicle.Buyer?.Name ?? "<null>"}. ");
            }

            var generatedSql = vehiclesQueryable.ToQueryString();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Generated sql query:");
            Console.WriteLine(generatedSql);
        }

        public static void UseToSqlQuery()
        {
            using var dbContext = new ApplicationDbContext();

            var vehiclesQueryable = dbContext.Vehicles;

            var vehicles = vehiclesQueryable.ToList();

            Console.WriteLine(new string('-', 80));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle's name: {vehicle.Name}. Vehicle's price: {vehicle.Price}. Buyer's name: {vehicle.Buyer?.Name ?? "<null>"}. ");
            }

            var generatedSql = vehiclesQueryable.ToQueryString();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Generated sql query:");
            Console.WriteLine(generatedSql);
        }

        public static void UseToFunction()
        {
            using var dbContext = new ApplicationDbContext();

            var vehiclesQueryable = dbContext.Vehicles;

            var vehicles = vehiclesQueryable.ToList();

            Console.WriteLine(new string('-', 80));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle's name: {vehicle.Name}. Vehicle's price: {vehicle.Price}. Buyer's name: {vehicle.Buyer?.Name ?? "<null>"}. ");
            }

            var generatedSql = vehiclesQueryable.ToQueryString();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Generated sql query:");
            Console.WriteLine(generatedSql);
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

            //Remove the comment using method UseToSqlQuery()
            //modelBuilder
            //    .Entity<Vehicle>()
            //    .ToSqlQuery("SELECT * FROM Vehicles WHERE Price > 30000");

            //Remove the comment using method UseToFunction()
            //modelBuilder
            //    .Entity<Vehicle>()
            //    .ToFunction("GetVehicleWithPriceLessThan20000");
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

