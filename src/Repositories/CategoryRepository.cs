using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private List<Category> _categorys;

    public CategoryRepository()
    {
        _categorys = new DatabaseContext().categorys;
    }

    public List<Category> FindAll()
    {
        return _categorys;
    }

    public List<Category> CreateOne(Category category)
    {
        _categorys.Add(category);
        return _categorys;
    }
}
