﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var dbContext = new ApplicationDbContext();

            dbContext.Database.EnsureCreated();

            dbContext.Database.ExecuteSqlRaw("SELECT 1");

            Console.WriteLine();
            Console.WriteLine($"Имя провайдера БД: {dbContext.Database.ProviderName}.");
            Console.WriteLine();
        }
    }

    // абстракция подключения к БД
    public class ApplicationDbContext : DbContext
    {
        // метод конфигурации подключения к БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder() // начали строить конфигурацию
                .AddUserSecrets<
                    ApplicationDbContext>() // добавили в конфигурацию пользовательские секреты
                .Build(); // построили готовую конфигурацию

            // посмотрим в консоли как выглядит построенная конфигурация
            Console.WriteLine(configuration.GetDebugView());

            // получаем из конфигурации строку подключения
            var connectionString = configuration.GetConnectionString("MyEFCoreDatabase");

            optionsBuilder
                .UseSqlServer(connectionString)
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
                .LogTo(
                    Console.WriteLine,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information);
        }
    }
}

