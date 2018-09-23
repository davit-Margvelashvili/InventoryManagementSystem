using InventoryManagementSystemPCL.Models.Abstractions;
using InventoryManagementSystemPCL.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Services.Implementations
{
    public class ProductService : IProductService
    {
        public Task<bool> AddProductAsync(IProduct product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditProductAsync(IProduct product)
        {
            throw new NotImplementedException();
        }

        public Task<List<IProduct>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<IProduct>> GetProductsByCategoryAsync(IProductCategory category)
        {
            throw new NotImplementedException();
        }
    }
}
