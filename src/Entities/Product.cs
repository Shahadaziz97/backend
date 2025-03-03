using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src;

public class Product
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
     public string Image { get; set; }
    public string Description { get; set; }
    public IEnumerable<Stock> Stocks { get; set; }
}
