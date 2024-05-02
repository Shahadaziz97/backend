using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers;

public class CategoryController : BaseController
{
    private ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public IEnumerable<Category> FindAll()
    {
        return _categoryService.FindAll();
    }

    // [HttpGet("{categoryId}")]
    // public Category? FindOne(string categoryId)
    // {
    //     Category? category = _categorys.FirstOrDefault( category => category.Id == categoryId );
    //     return category;
    // }

    [HttpPost]

    public Category CreateOne([FromBody] CategoryCreateDto category)
    {
        return _categoryService.CreateOne(category);
    }
}

/* 
GET /categorys
POST /categorys
GET /categorys/:categoryId
DELETE /categorys/:categoryId
PATCH /categorys/:categoryId
*/