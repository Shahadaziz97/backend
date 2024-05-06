using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IProductService
    {
        public IEnumerable<Product> FindAll();
        public Product? FindeOne(Guid Id);
        public Product CreateOne(PoductReadDTO product);
    }
}