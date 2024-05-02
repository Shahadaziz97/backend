using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DataBase;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository
{
    public class ProductRepository : IProductRepository
    {

        private DbSet<Product> _products;
        public ProductRepository(DatabaseContext databaseContext)
        {
            _products = databaseContext.Products;
        }


        public IEnumerable<Product> findAll()
        {
            return _products;
        }


        public Product? FindeOne(int Id)
        {
            Product? product = _products.FirstOrDefault(product => product.Id == Id);
            if (product != null)
            {
                return product;
            }
            return null;

        }
        public IEnumerable<Product> CreateOne(Product product)
        {
            _products.Add(product);
            return _products;
        }


    }
}