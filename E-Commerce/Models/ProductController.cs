using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using E_Commerce.Models;

namespace E_Commerce.Models
{
    [Route("api/[controller]")] // baseUrl/api/product
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: baseUrl/api/product
        [HttpGet("{ id}")]
        public ActionResult<Product> GetById(int id)
        {
           return new Product { Id = id };
        }

        // GET: baseUrl/api/product
        [HttpGet]
        public ActionResult<Product> GetAll()
        {
            return new Product { Id = 100 };
        }

        // POST: baseUrl/api/product
        [HttpPost]
        public ActionResult<Product> Add(Product product)
        {
            return product;
        }

        // PUT: baseUrl/api/product
        [HttpPut]
        public ActionResult<Product> Update(Product product)
        {
            return product;
        }

        // Delete: baseUrl/api/product
        [HttpDelete]
        public ActionResult<Product> Delete(Product product)
        {
            return product;
        }
    }
}
