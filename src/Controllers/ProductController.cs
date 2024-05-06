using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public IEnumerable<Product> FindAll()
        {
            return _productSarvice.FindAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> FindeOne(Guid id)
        {
            Product? findId = _productSarvice.FindeOne(id);
            if (findId is null) return NotFound();
            return findId;

        }
        [HttpPost]

        public ActionResult<Product> CreateOne([FromBody] PoductReadDTO product)
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