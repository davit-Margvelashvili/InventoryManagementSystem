using InventoryManagementSystemPCL.Models.Abstractions;
using InventoryManagementSystemPCL.Models.Implementations;
using InventoryManagementSystemPCL.Services.Abstractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Services.Implementations
{
    public class IMSWebClient : IProductService, IUnitService, ICategoryService
    {
        public static readonly IMSWebClient Instance = new IMSWebClient();
        private HttpClient _httpClient;
        public string BaseUrl { get; private set; } = "http://localhost:1924/api/";

        private string ProvideUrl(string url)
        {
            return BaseUrl + url;
        }

        public async Task<List<IProduct>> GetProductsAsync()
        {
            var url = ProvideUrl("Products");
            var response = await _httpClient.GetAsync(url);
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<ProductModel>>(jsonString).ToList<IProduct>();
            return result;
        }

        public Task<List<IProduct>> GetProductsByCategoryAsync(IProductCategory category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddProductAsync(IProduct product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditProductAsync(IProduct product)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IUnit>> GetUnitsAsync()
        {
            var url = ProvideUrl("Units");
            var response = await _httpClient.GetAsync(url);
            
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<UnitModel>>(jsonString).ToList<IUnit>();
            return result;
        }

        public Task<bool> AddUnitAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditUnitAsync(int id, string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<IProductCategory>> GetProductCategoriesAsync()
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

        public Task<bool> AddProductCategoryAsync(string categoryName)
        {
            throw new NotImplementedException();
        }

        static IMSWebClient()
        {
        }

        public IMSWebClient()
        {
            _httpClient = new HttpClient();
        }


    }
}
