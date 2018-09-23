using InventoryManagementSystemPCL.Models.Abstractions;
using InventoryManagementSystemPCL.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Services.Implementations
{
    public class UnitService : IUnitService
    {
        public Task<bool> AddUnitAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditUnitAsync(int id, string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<IUnit>> GetUnitsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
