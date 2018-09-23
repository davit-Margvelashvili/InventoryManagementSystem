using InventoryManagementSystemPCL.Services.Abstractions;
using InventoryManagementSystemPCL.Services.Implementations;
using InventoryManagementSystemPCL.TestServices;
using MPDC.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL
{
    public static class AppConfig
    {
       static public void RegistreServices()
        {
            MPDCContainer
                .Instance
                .Register<ICategoryService, CategoryTestService>(() => new CategoryTestService());

            MPDCContainer
              .Instance
              .Register<IUnitService, UnitTestService>(() => new UnitTestService());

        }
    }
}
