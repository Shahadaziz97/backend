using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;

public class DatabaseContext : DbContext
{
    public DbSet<Category> categorys { get; set;}
    public DbSet<User> users { get; set;}

    private IConfiguration _config;
    public DatabaseContext(IConfiguration config)
    {
        _config = config;}
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};password={_config["Db:Password"]};Database={_config["Db:Database"]}");

    }











