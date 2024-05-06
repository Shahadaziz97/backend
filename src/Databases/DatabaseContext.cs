
using Hanan_csharp_backend_teamwork.src.Entities;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;

public class DatabaseContext : DbContext
{
    private IConfiguration _config;

    public DbSet<Category> Category { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<Stock> Stock { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Order> Order { get; set; }

    public DatabaseContext(IConfiguration config)
    {
        _config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};password={_config["Db:Password"]};Database={_config["Db:Database"]}")
    .UseSnakeCaseNamingConvention();


}
