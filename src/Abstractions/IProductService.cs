using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IProductService
    {
        public IEnumerable<ProductReadDTO> FindAll(int limit, int offset);
        public Product? FindeOne(Guid Id);
        public Product CreateOne(ProductReadDTO product);
    }
}