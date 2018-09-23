using InventoryManagementSystemPCL.Models.Implementations;
using InventoryManagementSystemPCL.Services.Abstractions;
using InventoryManagementSystemPCL.Services.Implementations;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

       

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var service = MPDC.Container.MPDCContainer.Instance.Get<ICategoryService>();
            var categories = await service.GetProductCategoriesAsync();
        }
    }
}
