namespace InventoryManagementSystemUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddProductButton = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.salesButton = new System.Windows.Forms.ToolStripButton();
            this.InventoryButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.AddProductButton.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.AutoSize = false;
            this.AddProductButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesButton,
            this.InventoryButton,
            this.toolStripButton1});
            this.AddProductButton.Location = new System.Drawing.Point(0, 0);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(893, 50);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(893, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // salesButton
            // 
            this.salesButton.AutoSize = false;
            this.salesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salesButton.Image = ((System.Drawing.Image)(resources.GetObject("salesButton.Image")));
            this.salesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(50, 50);
            this.salesButton.Text = "გაყოდვები";
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.AutoSize = false;
            this.InventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InventoryButton.Image = ((System.Drawing.Image)(resources.GetObject("InventoryButton.Image")));
            this.InventoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(50, 50);
            this.InventoryButton.Text = "მარაგები";
            this.InventoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 47);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(893, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.AddProductButton);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AddProductButton.ResumeLayout(false);
            this.AddProductButton.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip AddProductButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton salesButton;
        private System.Windows.Forms.ToolStripButton InventoryButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}



