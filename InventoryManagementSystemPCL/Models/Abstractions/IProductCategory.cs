﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPCL.Models.Abstractions
{
    public interface IProductCategory
    {
        int Id { get; set; }
        string Description { get; set; }
    }
}
