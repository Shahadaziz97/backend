
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;

public class DatabaseContext
{

    public IEnumerable<Stock> stock;

    public DatabaseContext()
    {
        stock = [
            new Stock(1,2,30,150,"Red",'M'),
            new Stock(2,2,20,180,"BLACK",'L'),
            new Stock(3,4,40,230,"Blue",'M'),
            new Stock(4,5,15,650,"black",'S'),
            new Stock(5,6,22,350,"White",'L'),
            new Stock(6,9,54,750,"Yellow",'S'),
            new Stock(7,8,34,250,"green",'M'),
        ];
    }
}
