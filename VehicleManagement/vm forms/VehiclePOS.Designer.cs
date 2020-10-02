namespace Sarasi_HMS.VehicleManagement.vm_forms
{
    partial class VehiclePOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclePOS));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMainStock = new System.Windows.Forms.Panel();
            this.buniPanelTopStock = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRentHistory = new System.Windows.Forms.Button();
            this.btnNewrent = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.buniPanelTopStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panelMainStock
            // 
            this.panelMainStock.BackColor = System.Drawing.Color.Black;
            this.panelMainStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainStock.Location = new System.Drawing.Point(0, 37);
            this.panelMainStock.Name = "panelMainStock";
            this.panelMainStock.Size = new System.Drawing.Size(870, 96);
            this.panelMainStock.TabIndex = 11;
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
            this.buniPanelTopStock.Size = new System.Drawing.Size(870, 37);
            this.buniPanelTopStock.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(819, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // btnRentHistory
            // 
            this.btnRentHistory.BackColor = System.Drawing.Color.Black;
            this.btnRentHistory.FlatAppearance.BorderSize = 0;
            this.btnRentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentHistory.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentHistory.ForeColor = System.Drawing.Color.White;
            this.btnRentHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnRentHistory.Image")));
            this.btnRentHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentHistory.Location = new System.Drawing.Point(260, 199);
            this.btnRentHistory.Name = "btnRentHistory";
            this.btnRentHistory.Size = new System.Drawing.Size(358, 89);
            this.btnRentHistory.TabIndex = 13;
            this.btnRentHistory.Text = "     Rent History";
            this.btnRentHistory.UseVisualStyleBackColor = false;
            // 
            // btnNewrent
            // 
            this.btnNewrent.BackColor = System.Drawing.Color.Black;
            this.btnNewrent.FlatAppearance.BorderSize = 0;
            this.btnNewrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewrent.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewrent.ForeColor = System.Drawing.Color.White;
            this.btnNewrent.Image = ((System.Drawing.Image)(resources.GetObject("btnNewrent.Image")));
            this.btnNewrent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewrent.Location = new System.Drawing.Point(260, 331);
            this.btnNewrent.Name = "btnNewrent";
            this.btnNewrent.Size = new System.Drawing.Size(358, 89);
            this.btnNewrent.TabIndex = 14;
            this.btnNewrent.Text = "New Rent";
            this.btnNewrent.UseVisualStyleBackColor = false;
            this.btnNewrent.Click += new System.EventHandler(this.btnNewrent_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Black;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.Location = new System.Drawing.Point(314, 452);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(264, 69);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            // 
            // VehiclePOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 582);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnNewrent);
            this.Controls.Add(this.btnRentHistory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMainStock);
            this.Controls.Add(this.buniPanelTopStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehiclePOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehiclePOS";
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
        private System.Windows.Forms.Button btnRentHistory;
        private System.Windows.Forms.Button btnNewrent;
        private System.Windows.Forms.Button btnback;
    }
}