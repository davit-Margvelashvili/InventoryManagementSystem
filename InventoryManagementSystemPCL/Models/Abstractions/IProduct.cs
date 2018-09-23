using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Models.Abstractions
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        int CategoryId { get; set; }
        int UnitId { get; set; }
        decimal Price { get; set; }
    }
}
