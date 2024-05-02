
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;

public class DatabaseContext : DbContext
{

    public DbSet<Stock> Stock { get; set; }
    private IConfiguration _config;

    public DatabaseContext(IConfiguration config)
    {
        _config = config;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Password={_config["Db:Password"]};Database={_config["Db:Database"]}").UseSnakeCaseNamingConvention().UseLowerCaseNamingConvention();


    // Guid ID = Guid.NewGuid();
    // Guid ID1 =Guid.NewGuid();
    // Guid ID2=Guid.NewGuid();
    // Guid ID3 =Guid.NewGuid();
    // Guid ID4 =Guid.NewGuid();
    // Guid ID5 =Guid.NewGuid();
    // Guid ID6 =Guid.NewGuid();
    // Guid ID7 =Guid.NewGuid();
    // public DatabaseContext()
    // {

    //     stock = [
    //         new Stock(30,150,"Red",'M'),
    //         new Stock(20,180,"BLACK",'L'),
    //         new Stock(40,230,"Blue",'M'),
    //         new Stock(15,650,"black",'S'),
    //         new Stock(22,350,"White",'L'),
    //         // new Stock(ID,54,750,"Yellow",'S'),
    //         // new Stock(ID,34,250,"green",'M'),
    //     ];
    // }
}
