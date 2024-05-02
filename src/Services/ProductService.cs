using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DataBase;

using sda_onsite_2_csharp_backend_teamwork.src.Repository;

namespace sda_onsite_2_csharp_backend_teamwork.src.services
{
    public class ProductService : IProductService
    {
        private IProductRepository _ProductRepository;

        public ProductService(IProductRepository productRepository)
        {
            _ProductRepository = productRepository;
        }

        public IEnumerable<Product> findAll()
        {
            return _ProductRepository.findAll();
        }


        public Product? FindeOne(int Id)
        {
            
            return _ProductRepository.FindeOne(Id);

        }
        public IEnumerable<Product> CreateOne(Product product)
        {
            return _ProductRepository.CreateOne(product);
        }
    }
}