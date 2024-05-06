using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;

namespace sda_onsite_2_csharp_backend_teamwork.src.services
{
    public class ProductService : IProductService
    {
        private IProductRepository _ProductRepository;
        private IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _ProductRepository = productRepository;
            _mapper = mapper;
        }
        public IEnumerable<Product> FindAll()
        {
            return _ProductRepository.FindAll();
        }
        public Product? FindeOne(Guid Id)
        {

            return _ProductRepository.FindeOne(Id);

        }
        public Product CreateOne(PoductReadDTO product)
        {
            Product creatProduct = _mapper.Map<Product>(product);
            return _ProductRepository.CreateOne(creatProduct);
        }
    }
}