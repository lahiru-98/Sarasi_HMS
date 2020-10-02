namespace Sarasi_HMS
{
    partial class KitchenPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenPOS));
            this.buniPanelTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.foodSerach = new Bunifu.Framework.UI.BunifuTextbox();
            this.flowCategoryButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.flowKitchenItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRetriew = new System.Windows.Forms.Button();
            this.btnCancelFood = new System.Windows.Forms.Button();
            this.flowStockOut = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBottomKitchenPOS = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelBottom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOutAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMainKitchenPOS = new System.Windows.Forms.Panel();
            this.btnPOSSettings = new Guna.UI.WinForms.GunaImageButton();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buniPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelBottomKitchenPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMainKitchenPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buniPanelTop
            // 
            this.buniPanelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buniPanelTop.BackgroundImage")));
            this.buniPanelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniPanelTop.Controls.Add(this.btnClose);
            this.buniPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.buniPanelTop.GradientBottomLeft = System.Drawing.Color.SaddleBrown;
            this.buniPanelTop.GradientBottomRight = System.Drawing.Color.White;
            this.buniPanelTop.GradientTopLeft = System.Drawing.Color.Gold;
            this.buniPanelTop.GradientTopRight = System.Drawing.Color.White;
            this.buniPanelTop.Location = new System.Drawing.Point(0, 0);
            this.buniPanelTop.Name = "buniPanelTop";
            this.buniPanelTop.Quality = 10;
            this.buniPanelTop.Size = new System.Drawing.Size(1264, 37);
            this.buniPanelTop.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1213, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // foodSerach
            // 
            this.foodSerach.BackColor = System.Drawing.Color.White;
            this.foodSerach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("foodSerach.BackgroundImage")));
            this.foodSerach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodSerach.ForeColor = System.Drawing.Color.Goldenrod;
            this.foodSerach.Icon = ((System.Drawing.Image)(resources.GetObject("foodSerach.Icon")));
            this.foodSerach.Location = new System.Drawing.Point(177, 142);
            this.foodSerach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foodSerach.Name = "foodSerach";
            this.foodSerach.Size = new System.Drawing.Size(307, 52);
            this.foodSerach.TabIndex = 10;
            this.foodSerach.text = "";
            // 
            // flowCategoryButtons
            // 
            this.flowCategoryButtons.AutoScroll = true;
            this.flowCategoryButtons.BackColor = System.Drawing.Color.White;
            this.flowCategoryButtons.Location = new System.Drawing.Point(559, 142);
            this.flowCategoryButtons.Name = "flowCategoryButtons";
            this.flowCategoryButtons.Size = new System.Drawing.Size(246, 513);
            this.flowCategoryButtons.TabIndex = 12;
            // 
            // flowKitchenItems
            // 
            this.flowKitchenItems.BackColor = System.Drawing.Color.White;
            this.flowKitchenItems.Location = new System.Drawing.Point(828, 142);
            this.flowKitchenItems.Name = "flowKitchenItems";
            this.flowKitchenItems.Size = new System.Drawing.Size(424, 552);
            this.flowKitchenItems.TabIndex = 13;
            // 
            // btnRetriew
            // 
            this.btnRetriew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.btnRetriew.FlatAppearance.BorderSize = 2;
            this.btnRetriew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetriew.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetriew.ForeColor = System.Drawing.Color.White;
            this.btnRetriew.Location = new System.Drawing.Point(260, 219);
            this.btnRetriew.Name = "btnRetriew";
            this.btnRetriew.Size = new System.Drawing.Size(205, 54);
            this.btnRetriew.TabIndex = 17;
            this.btnRetriew.TabStop = false;
            this.btnRetriew.Text = "Retriew";
            this.btnRetriew.UseVisualStyleBackColor = false;
            this.btnRetriew.Click += new System.EventHandler(this.btnRetriew_Click);
            // 
            // btnCancelFood
            // 
            this.btnCancelFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(113)))));
            this.btnCancelFood.FlatAppearance.BorderSize = 2;
            this.btnCancelFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFood.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFood.ForeColor = System.Drawing.Color.Black;
            this.btnCancelFood.Location = new System.Drawing.Point(26, 219);
            this.btnCancelFood.Name = "btnCancelFood";
            this.btnCancelFood.Size = new System.Drawing.Size(205, 54);
            this.btnCancelFood.TabIndex = 16;
            this.btnCancelFood.TabStop = false;
            this.btnCancelFood.Text = "Cancel";
            this.btnCancelFood.UseVisualStyleBackColor = false;
            // 
            // flowStockOut
            // 
            this.flowStockOut.BackColor = System.Drawing.Color.White;
            this.flowStockOut.Location = new System.Drawing.Point(12, 282);
            this.flowStockOut.Name = "flowStockOut";
            this.flowStockOut.Size = new System.Drawing.Size(525, 306);
            this.flowStockOut.TabIndex = 18;
            // 
            // panelBottomKitchenPOS
            // 
            this.panelBottomKitchenPOS.BackColor = System.Drawing.Color.Black;
            this.panelBottomKitchenPOS.Controls.Add(this.pictureBox4);
            this.panelBottomKitchenPOS.Controls.Add(this.lblDateTime);
            this.panelBottomKitchenPOS.Controls.Add(this.pictureBox3);
            this.panelBottomKitchenPOS.Controls.Add(this.labelBottom);
            this.panelBottomKitchenPOS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomKitchenPOS.Location = new System.Drawing.Point(0, 658);
            this.panelBottomKitchenPOS.Name = "panelBottomKitchenPOS";
            this.panelBottomKitchenPOS.Size = new System.Drawing.Size(1264, 48);
            this.panelBottomKitchenPOS.TabIndex = 19;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(914, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(1006, 16);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(61, 23);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "Time";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(844, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // labelBottom
            // 
            this.labelBottom.AutoSize = true;
            this.labelBottom.BackColor = System.Drawing.Color.Transparent;
            this.labelBottom.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBottom.ForeColor = System.Drawing.Color.White;
            this.labelBottom.Location = new System.Drawing.Point(408, 16);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(387, 23);
            this.labelBottom.TabIndex = 0;
            this.labelBottom.Text = "2020@CodeSpace All rights reserved ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblOutAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 57);
            this.panel1.TabIndex = 20;
            // 
            // lblOutAmount
            // 
            this.lblOutAmount.AutoSize = true;
            this.lblOutAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblOutAmount.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutAmount.ForeColor = System.Drawing.Color.White;
            this.lblOutAmount.Location = new System.Drawing.Point(343, 11);
            this.lblOutAmount.Name = "lblOutAmount";
            this.lblOutAmount.Size = new System.Drawing.Size(109, 33);
            this.lblOutAmount.TabIndex = 3;
            this.lblOutAmount.Text = "945.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Stock Out ";
            // 
            // panelMainKitchenPOS
            // 
            this.panelMainKitchenPOS.BackColor = System.Drawing.Color.Black;
            this.panelMainKitchenPOS.Controls.Add(this.btnPOSSettings);
            this.panelMainKitchenPOS.Controls.Add(this.btnLogout);
            this.panelMainKitchenPOS.Controls.Add(this.label1);
            this.panelMainKitchenPOS.Controls.Add(this.gunaCirclePictureBox1);
            this.panelMainKitchenPOS.Controls.Add(this.gunaImageButton1);
            this.panelMainKitchenPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainKitchenPOS.Location = new System.Drawing.Point(0, 37);
            this.panelMainKitchenPOS.Name = "panelMainKitchenPOS";
            this.panelMainKitchenPOS.Size = new System.Drawing.Size(1264, 96);
            this.panelMainKitchenPOS.TabIndex = 21;
            // 
            // btnPOSSettings
            // 
            this.btnPOSSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOSSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnPOSSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPOSSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnPOSSettings.Image")));
            this.btnPOSSettings.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPOSSettings.Location = new System.Drawing.Point(742, 6);
            this.btnPOSSettings.Name = "btnPOSSettings";
            this.btnPOSSettings.OnHoverImage = null;
            this.btnPOSSettings.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnPOSSettings.Size = new System.Drawing.Size(86, 77);
            this.btnPOSSettings.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1208, 36);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 47);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 3;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1014, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(915, 6);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(93, 90);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 1;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(844, 6);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(47, 60);
            this.gunaImageButton1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // KitchenPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 706);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMainKitchenPOS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottomKitchenPOS);
            this.Controls.Add(this.flowStockOut);
            this.Controls.Add(this.flowKitchenItems);
            this.Controls.Add(this.btnRetriew);
            this.Controls.Add(this.btnCancelFood);
            this.Controls.Add(this.flowCategoryButtons);
            this.Controls.Add(this.foodSerach);
            this.Controls.Add(this.buniPanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitchenPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenPOS";
            this.Load += new System.EventHandler(this.KitchenPOS_Load);
            this.buniPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelBottomKitchenPOS.ResumeLayout(false);
            this.panelBottomKitchenPOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMainKitchenPOS.ResumeLayout(false);
            this.panelMainKitchenPOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel buniPanelTop;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuTextbox foodSerach;
        private System.Windows.Forms.FlowLayoutPanel flowCategoryButtons;
        private System.Windows.Forms.FlowLayoutPanel flowKitchenItems;
        private System.Windows.Forms.Button btnRetriew;
        private System.Windows.Forms.Button btnCancelFood;
        private System.Windows.Forms.FlowLayoutPanel flowStockOut;
        private System.Windows.Forms.Panel panelBottomKitchenPOS;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutAmount;
        private System.Windows.Forms.Panel panelMainKitchenPOS;
        private Guna.UI.WinForms.GunaImageButton btnPOSSettings;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}