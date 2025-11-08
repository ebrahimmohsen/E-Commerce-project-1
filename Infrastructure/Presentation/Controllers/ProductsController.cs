using Microsoft.AspNetCore.Mvc;
using ServiceAbstraction;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // baseUrl/api/products

    public class ProductsController(IServiceManager _serviceManager) : ControllerBase
    {
        //Get all products
        [HttpGet]
        // GET: baseUrl/api/products
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var products =await  _serviceManager.ProductService.GetAllProductsAsync();
            return Ok(products);

        }

        //Get product by id
        [HttpGet("{id:int}")]
        // GET: baseUrl/api/products/10
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            var product = await _serviceManager.ProductService.GetProductByIdAsync(id);
            return Ok(product);
        }
        //Get all brands
        [HttpGet("brands")]
        // GET: baseUrl/api/products/brands
        public async Task<ActionResult<IEnumerable<BrandDto>>> GetAllBrands()
        {
            var brands = await _serviceManager.ProductService.GetAllBrandsAsync();
            return Ok(brands);
        }
        //Get all types
        [HttpGet("types")]
        // GET: baseUrl/api/products/types
        public async Task<ActionResult<IEnumerable<TypeDto>>> GetAllTypes()
        {
            var types = await _serviceManager.ProductService.GetAllTypesAsync();
            return Ok(types);
        }


    }
}
