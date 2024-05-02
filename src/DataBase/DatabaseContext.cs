using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork.src.DataBase
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        // public DbSet<Stock> Stock { get; set; }
        // public DbSet<User> User { get; set; }
        // public DbSet<Category> Category { get; set; }

        private IConfiguration _config;

        public DatabaseContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Password={_config["Db:Password"]};Database={_config["Db:Database"]}");

        // public DatabaseContext()
        // {
        //     products = [
        //         new Product (1 , 1, "shirt", "bla bla bla "),
        //         new Product (2 , 2, "flat", "bla bla bla"),
        //         new Product (3 , 3, "lipStick", "bla bla bla"),
        //         new Product (4 , 4, "candle", "bla bla bla")
        //     ];
        // }
    }
}