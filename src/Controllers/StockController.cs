
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers;
public class StockController : BaseController
{

    private IStockService _stockService;


    public StockController(IStockService stockService)
    {
        _stockService = stockService;
    }

    [HttpGet]
    public IEnumerable<Stock> FindAll()
    {
        return _stockService.FindAll();

    }

    [HttpPost]
    public ActionResult<IEnumerable<Stock>> CreateOne(Stock newProduct)
    {

        return CreatedAtAction(nameof(CreateOne), _stockService.CreateOne(newProduct));
    }
    // stocks/{pId}
    // stocks/{id}
    [HttpGet("products/{productId}")]

    public IEnumerable<Stock> FindByProductId(int productId)
    {
        return _stockService.FindByProductId(productId);
    }

    [HttpGet("{id}")]
    public ActionResult<Stock> FindById(int id)
    {
        var stock = _stockService.FindById(id);

        if (stock is null)
        {
            return NotFound();
        }
        return stock;
    }

    [HttpDelete("{id}")]
    public ActionResult DeletOneById(int id)
    {
        _stockService.DeletOneById(id);
        return NoContent();
    }
    [HttpDelete("products/{productId}")]

    public IEnumerable<Stock> DeletProductById(int productId)
    {
        return _stockService.DeletProductById(productId);
    }





}
