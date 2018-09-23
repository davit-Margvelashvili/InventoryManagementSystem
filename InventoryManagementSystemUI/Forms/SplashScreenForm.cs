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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();
            if(progressBar.Value >= progressBar.Maximum)
            {
                timer.Enabled = false;
                this.Hide();
                var mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}
