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
    public class UnitTestService : IUnitService
    {
        public Task<bool> AddUnitAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditUnitAsync(int id, string name)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IUnit>> GetUnitsAsync()
        {
            var units = new List<IUnit>
            {
                new UnitModel
                {
                    Id = 1,
                    Description = "კგ",
                },

                new UnitModel
                {
                    Id = 2,
                    Description = "გრ",
                },

                new UnitModel
                {
                    Id = 3,
                    Description = "ლიტრი",
                },

                 new UnitModel
                {
                    Id = 4,
                    Description = "ცალი",
                },

            };

            return units;
        }
    }
}
