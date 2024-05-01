using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

    public class CategoryRepository : ICategoryRepository
    {
    private DbSet<Category> _categorys;

    public CategoryRepository(DatabaseContext databaseContext)
    {
      _categorys = databaseContext.categorys;
    }

    public IEnumerable<Category> FindAll()
    {
        return _categorys;
    }

    public IEnumerable<Category> CreateOne(Category category)
    {
        _categorys.Add(category);
        return _categorys;
    }
}
