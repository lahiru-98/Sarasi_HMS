namespace Sarasi_HMS
{
    partial class AddNewRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewRent));
            this.panelMainStock = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buniPanelTopStock = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowRentVehiclePanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.buniPanelTopStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainStock
            // 
            this.panelMainStock.BackColor = System.Drawing.Color.Black;
            this.panelMainStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainStock.Location = new System.Drawing.Point(0, 37);
            this.panelMainStock.Name = "panelMainStock";
            this.panelMainStock.Size = new System.Drawing.Size(1136, 96);
            this.panelMainStock.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // buniPanelTopStock
            // 
            this.buniPanelTopStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buniPanelTopStock.BackgroundImage")));
            this.buniPanelTopStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniPanelTopStock.Controls.Add(this.btnClose);
            this.buniPanelTopStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.buniPanelTopStock.GradientBottomLeft = System.Drawing.Color.SaddleBrown;
            this.buniPanelTopStock.GradientBottomRight = System.Drawing.Color.White;
            this.buniPanelTopStock.GradientTopLeft = System.Drawing.Color.Gold;
            this.buniPanelTopStock.GradientTopRight = System.Drawing.Color.White;
            this.buniPanelTopStock.Location = new System.Drawing.Point(0, 0);
            this.buniPanelTopStock.Name = "buniPanelTopStock";
            this.buniPanelTopStock.Quality = 10;
            this.buniPanelTopStock.Size = new System.Drawing.Size(1136, 37);
            this.buniPanelTopStock.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1085, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // flowRentVehiclePanel
            // 
            this.flowRentVehiclePanel.Location = new System.Drawing.Point(12, 208);
            this.flowRentVehiclePanel.Name = "flowRentVehiclePanel";
            this.flowRentVehiclePanel.Size = new System.Drawing.Size(1112, 373);
            this.flowRentVehiclePanel.TabIndex = 16;
            // 
            // AddNewRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 593);
            this.Controls.Add(this.flowRentVehiclePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMainStock);
            this.Controls.Add(this.buniPanelTopStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewRent";
            this.Load += new System.EventHandler(this.AddNewRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.buniPanelTopStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMainStock;
        private Bunifu.Framework.UI.BunifuGradientPanel buniPanelTopStock;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowRentVehiclePanel;
    }
}