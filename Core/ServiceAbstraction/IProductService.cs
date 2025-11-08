using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAbstraction
{
    public interface IProductService
    {
        //Get all products
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        //Get product by id
        Task<ProductDto?> GetProductByIdAsync(int id);
        //Get all brands
        Task<IEnumerable<BrandDto>>GetAllBrandsAsync();
        Task<IEnumerable<TypeDto>> GetAllTypesAsync();

    }
}
