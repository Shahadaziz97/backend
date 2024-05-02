using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DataBase;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class ProductController : ControllerBase
    {
        private IProductService _productSarvice;
        public ProductController(IProductService productSarvice)
        {
            _productSarvice = productSarvice;
        }

        [HttpGet]
        public IEnumerable<Product> FindAll()
        {
            return _productSarvice.findAll();
        }

        [HttpGet("{id}")]
        public Product FindeOne(int id)
        {

            return _productSarvice.FindeOne(id);
        }
        [HttpPost]
        public ActionResult<IEnumerable<Product>> CreateOne([FromBody] Product product)
        {
            if (product is not null)
            {
                _productSarvice.CreateOne(product);
                return CreatedAtAction(nameof(CreateOne), product);
            }
            return BadRequest();
        }

    }
}