using InventoryManagementSystemPCL.Models.Abstractions;
using InventoryManagementSystemPCL.Services.Abstractions;
using MPDC.Container;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemUI.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private async void AddProductForm_Load(object sender, EventArgs e)
        {
            var categoryService = MPDCContainer.Instance.Get<ICategoryService>();
            var unitService = MPDCContainer.Instance.Get<IUnitService>();

            var categories = await categoryService.GetProductCategoriesAsync();
            var units = await unitService.GetUnitsAsync();

            unitsCb.DataSource = units;
            unitsCb.DisplayMember = nameof(IUnit.Description);
            unitsCb.ValueMember = nameof(IUnit.Id);

            categoryCb.DataSource = categories;
            categoryCb.DisplayMember = nameof(IProductCategory.Description);
            categoryCb.ValueMember = nameof(IProductCategory.Id);

        }
    }
}
