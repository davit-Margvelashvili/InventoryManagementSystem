using InventoryManagementSystemPCL.Models.Abstractions;
using InventoryManagementSystemPCL.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        public Task<bool> AddProductCategoryAsync(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditProductCategoryByIdAsync(int categoryId, string newName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditProductCategoryByNameAsync(string oldName, string newName)
        {
            throw new NotImplementedException();
        }

        public Task<List<IProductCategory>> GetProductCategoriesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
