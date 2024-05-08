using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{

    public class ProductController : BaseController
    {
        private IProductService _productSarvice;
        public ProductController(IProductService productSarvice)
        {
            _productSarvice = productSarvice;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Product>> FindAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
        {
            return Ok(_productSarvice.FindAll(limit, offset));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]


        public ActionResult<Product> FindeOne(Guid id)
        {
            Product? findId = _productSarvice.FindeOne(id);
            if (findId is null) return NotFound();
            return Ok(findId);

        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]



        public ActionResult<Product> CreateOne([FromBody] ProductReadDTO newProduct)
        {
            if (newProduct is not null)
            {
                var product = _productSarvice.CreateOne(newProduct);
                return CreatedAtAction(nameof(CreateOne), product);
            }
            return BadRequest();
        }

    }
}