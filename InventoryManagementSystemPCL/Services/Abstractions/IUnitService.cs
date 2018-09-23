using InventoryManagementSystemPCL.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Services.Abstractions
{
    public interface IUnitService
    {
        Task<List<IUnit>> GetUnitsAsync();
        Task<bool> AddUnitAsync(string name);
        Task<bool> EditUnitAsync(int id, string name);

    }
}
