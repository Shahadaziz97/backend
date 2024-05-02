namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IProductRepository
    {
      public IEnumerable<Product> findAll();

        public Product? FindeOne(int Id);
        public IEnumerable<Product> CreateOne(Product product);   
    }
}