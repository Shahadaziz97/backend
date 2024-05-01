
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
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Stock> CreateOne(Stock newProduct)
    {
        if (newProduct is not null)
        {
            _stockService.CreateOne(newProduct);
            return CreatedAtAction(nameof(CreateOne), newProduct);

        }

        return BadRequest();
    }

    // stocks/{pId}
    // stocks/{id}
    [HttpGet("products/{productId}")]

    public IEnumerable<Stock> FindByProductId(Guid productId)
    {
        return _stockService.FindByProductId(productId);
    }

    [HttpGet("{id}")]
    public ActionResult<Stock> FindById(Guid id)
    {
        var stock = _stockService.FindById(id);

        if (stock is null)
        {
            return NotFound();
        }
        return stock;
    }

    [HttpDelete("{id}")]
    public ActionResult DeletOneById(Guid id)
    {
        _stockService.DeletOneById(id);
        return NoContent();
    }
    [HttpDelete("products/{productId}")]

    public ActionResult DeletProductById(Guid productId)
    {
        _stockService.DeletProductById(productId);
        return NoContent();
    }





}
