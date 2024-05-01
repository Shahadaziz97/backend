using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class CategoryService : ICategoryService
{
    private ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IEnumerable<Category> CreateOne(Category category)
    {
        return _categoryRepository.CreateOne(category);
    }

    public IEnumerable<Category> FindAll()
    {
        return _categoryRepository.FindAll();
    }
}
