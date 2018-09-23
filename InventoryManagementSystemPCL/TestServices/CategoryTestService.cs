using InventoryManagementSystemPCL.Models.Abstractions;
using InventoryManagementSystemPCL.Models.Implementations;
using InventoryManagementSystemPCL.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.TestServices
{
    public class CategoryTestService : ICategoryService
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

        public async Task<List<IProductCategory>> GetProductCategoriesAsync()
        {
            var productCategories = new List<IProductCategory>
            {
                new ProductCategoryModel
                {
                    Id = 1,
                    Description = "ცივი სასმელები",
                },

                new ProductCategoryModel
                {
                    Id = 2,
                    Description = "ცხელი სასმელები",
                },

                 new ProductCategoryModel
                 {
                   Id = 3,
                   Description = "საკვები",
                 },
            };

            return productCategories;
        }
    }
}
