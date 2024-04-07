using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingDB
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Assets;Integrated Security=True";

        public DbSet<Asset1> Assets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Asset1>().HasData(new Asset1 { Id = 1, Type = "Laptop", Brand = "Lenovo", Model = "IdeaPad", Office ="Sweden" ,PurchaseDate = Convert.ToDateTime("21-03-30"), Price = 6290, Currency = "SEK"});
            ModelBuilder.Entity<Asset1>().HasData(new Asset1 { Id = 2, Type = "MobilePhone", Brand = "IPhone", Model = "SE", Office = "Sweden", PurchaseDate = Convert.ToDateTime("21-05-15"), Price = 6590, Currency = "SEK" });
            ModelBuilder.Entity<Asset1>().HasData(new Asset1 { Id = 3, Type = "Laptop", Brand = "Asus", Model = "Vivobook", Office = "Denmark", PurchaseDate = Convert.ToDateTime("21-07-06"), Price = 5499, Currency = "DKK" });
            ModelBuilder.Entity<Asset1>().HasData(new Asset1 { Id = 4, Type = "MobilePhone", Brand = "Samsung", Model = "Galaxy S", Office = "Denmark", PurchaseDate = Convert.ToDateTime("22-01-10"), Price = 8990, Currency = "DKK" });
            ModelBuilder.Entity<Asset1>().HasData(new Asset1 { Id = 5, Type = "Laptop", Brand = "MacBook", Model = "Air", Office = "US", PurchaseDate = Convert.ToDateTime("23-12-22"), Price = 18975, Currency = "USD" });
            ModelBuilder.Entity<Asset1>().HasData(new Asset1 { Id = 6, Type = "MobilePhone", Brand = "IPhone", Model = "15", Office = "US", PurchaseDate = Convert.ToDateTime("24-01-07"), Price = 11990, Currency = "USD" });
        }
    }
}
