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

        private void salesButton_Click(object sender, EventArgs e)
        {
            var salesForm = new SalesForm();
            salesForm.MdiParent = this;
            salesForm.Show();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm();
            inventoryForm.MdiParent = this;
            inventoryForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.MdiParent = this;
            addProductForm.Show();
        }
    }
}
