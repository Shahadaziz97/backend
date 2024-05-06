using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
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
    public ActionResult<Stock> CreateOne(StockCreateDto newStock)
    {
        if (newStock is null)
        {
            return BadRequest();
        }
        _stockService.CreateOne(newStock);
        return CreatedAtAction(nameof(CreateOne), newStock);
    }

    // stocks/{pId}
    // stocks/{id}
    [HttpGet("products/{productId}")]

    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public ActionResult<IEnumerable<Stock>> FindByProductId(Guid productId)
    {
        // return _stockService.FindByProductId(productId);

        var stockProduct = _stockService.FindByProductId(productId);

        if (stockProduct is null)
        {
            return NotFound();
        }
        return Ok(stockProduct);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

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
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public ActionResult DeleteOneById(Guid id)
    {
        _stockService.DeleteOneById(id);
        return NoContent();
    }


    [HttpDelete("products/{productId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public ActionResult DeleteProductById(Guid productId)
    {
        _stockService.DeleteProductById(productId);
        return NoContent();
    }

}
