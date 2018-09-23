using InventoryManagementSystemPCL.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Services.Abstractions
{
   public interface ICategoryService
    {
        Task<List<IProductCategory>> GetProductCategoriesAsync();
        Task<bool> EditProductCategoryByIdAsync(int categoryId, string newName);
        Task<bool> EditProductCategoryByNameAsync(string oldName, string newName);
        Task<bool> AddProductCategoryAsync(string categoryName);
    }
}
