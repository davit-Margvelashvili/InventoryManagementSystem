using InventoryManagementSystemPCL.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Services.Abstractions
{
    public interface IProductService
    {
        Task<List<IProduct>> GetProductsAsync();
        Task<List<IProduct>> GetProductsByCategoryAsync(IProductCategory category);
        Task<bool> AddProductAsync(IProduct product);
        Task<bool> EditProductAsync(IProduct product);

    }
}
