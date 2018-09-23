using InventoryManagementSystemPCL.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Models.Implementations
{
    public class UnitModel : IUnit
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
