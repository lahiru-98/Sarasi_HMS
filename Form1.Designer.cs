namespace Sarasi_HMS
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.buniPanelTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelBottom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFoodManagement = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnEventManagement = new System.Windows.Forms.Button();
            this.btnSupplierManagement = new System.Windows.Forms.Button();
            this.btnCustomerManagement = new System.Windows.Forms.Button();
            this.btnAccomodations = new System.Windows.Forms.Button();
            this.btnVehiclerentings = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnKitchenAndStock = new System.Windows.Forms.Button();
            this.buniPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.buniPanelTop.Size = new System.Drawing.Size(1282, 37);
            this.buniPanelTop.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1231, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnLogout);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.gunaCirclePictureBox1);
            this.panelMain.Controls.Add(this.gunaImageButton1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 37);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1282, 96);
            this.panelMain.TabIndex = 2;
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
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.gunaImageButton1.Size = new System.Drawing.Size(65, 60);
            this.gunaImageButton1.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Black;
            this.panelBottom.Controls.Add(this.pictureBox4);
            this.panelBottom.Controls.Add(this.lblDateTime);
            this.panelBottom.Controls.Add(this.pictureBox3);
            this.panelBottom.Controls.Add(this.labelBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 705);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1282, 48);
            this.panelBottom.TabIndex = 3;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnFoodManagement
            // 
            this.btnFoodManagement.BackColor = System.Drawing.Color.Black;
            this.btnFoodManagement.FlatAppearance.BorderSize = 0;
            this.btnFoodManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodManagement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodManagement.ForeColor = System.Drawing.Color.White;
            this.btnFoodManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnFoodManagement.Image")));
            this.btnFoodManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodManagement.Location = new System.Drawing.Point(78, 247);
            this.btnFoodManagement.Name = "btnFoodManagement";
            this.btnFoodManagement.Size = new System.Drawing.Size(358, 89);
            this.btnFoodManagement.TabIndex = 5;
            this.btnFoodManagement.Text = "Food Management  ";
            this.btnFoodManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoodManagement.UseVisualStyleBackColor = false;
            this.btnFoodManagement.Click += new System.EventHandler(this.btnFoodManagement_Click);
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.BackColor = System.Drawing.Color.Black;
            this.btnEmployeeManagement.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeManagement.Image")));
            this.btnEmployeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeManagement.Location = new System.Drawing.Point(464, 247);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(358, 89);
            this.btnEmployeeManagement.TabIndex = 6;
            this.btnEmployeeManagement.Text = "Employee Management  ";
            this.btnEmployeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployeeManagement.UseVisualStyleBackColor = false;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // btnEventManagement
            // 
            this.btnEventManagement.BackColor = System.Drawing.Color.Black;
            this.btnEventManagement.FlatAppearance.BorderSize = 0;
            this.btnEventManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventManagement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventManagement.ForeColor = System.Drawing.Color.White;
            this.btnEventManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnEventManagement.Image")));
            this.btnEventManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventManagement.Location = new System.Drawing.Point(78, 388);
            this.btnEventManagement.Name = "btnEventManagement";
            this.btnEventManagement.Size = new System.Drawing.Size(358, 89);
            this.btnEventManagement.TabIndex = 8;
            this.btnEventManagement.Text = "Event Management   ";
            this.btnEventManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEventManagement.UseVisualStyleBackColor = false;
            this.btnEventManagement.Click += new System.EventHandler(this.btnEventManagement_Click);
            // 
            // btnSupplierManagement
            // 
            this.btnSupplierManagement.BackColor = System.Drawing.Color.Black;
            this.btnSupplierManagement.FlatAppearance.BorderSize = 0;
            this.btnSupplierManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierManagement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierManagement.ForeColor = System.Drawing.Color.White;
            this.btnSupplierManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierManagement.Image")));
            this.btnSupplierManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierManagement.Location = new System.Drawing.Point(464, 388);
            this.btnSupplierManagement.Name = "btnSupplierManagement";
            this.btnSupplierManagement.Size = new System.Drawing.Size(358, 89);
            this.btnSupplierManagement.TabIndex = 9;
            this.btnSupplierManagement.Text = "Supplier Management  ";
            this.btnSupplierManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupplierManagement.UseVisualStyleBackColor = false;
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.BackColor = System.Drawing.Color.Black;
            this.btnCustomerManagement.FlatAppearance.BorderSize = 0;
            this.btnCustomerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerManagement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerManagement.ForeColor = System.Drawing.Color.White;
            this.btnCustomerManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerManagement.Image")));
            this.btnCustomerManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerManagement.Location = new System.Drawing.Point(859, 388);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Size = new System.Drawing.Size(358, 89);
            this.btnCustomerManagement.TabIndex = 10;
            this.btnCustomerManagement.Text = "Customer and Stock   ";
            this.btnCustomerManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerManagement.UseVisualStyleBackColor = false;
            // 
            // btnAccomodations
            // 
            this.btnAccomodations.BackColor = System.Drawing.Color.Black;
            this.btnAccomodations.FlatAppearance.BorderSize = 0;
            this.btnAccomodations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccomodations.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccomodations.ForeColor = System.Drawing.Color.White;
            this.btnAccomodations.Image = ((System.Drawing.Image)(resources.GetObject("btnAccomodations.Image")));
            this.btnAccomodations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccomodations.Location = new System.Drawing.Point(78, 524);
            this.btnAccomodations.Name = "btnAccomodations";
            this.btnAccomodations.Size = new System.Drawing.Size(358, 89);
            this.btnAccomodations.TabIndex = 11;
            this.btnAccomodations.Text = "Accomodations       ";
            this.btnAccomodations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccomodations.UseVisualStyleBackColor = false;
            // 
            // btnVehiclerentings
            // 
            this.btnVehiclerentings.BackColor = System.Drawing.Color.Black;
            this.btnVehiclerentings.FlatAppearance.BorderSize = 0;
            this.btnVehiclerentings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiclerentings.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiclerentings.ForeColor = System.Drawing.Color.White;
            this.btnVehiclerentings.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiclerentings.Image")));
            this.btnVehiclerentings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiclerentings.Location = new System.Drawing.Point(464, 524);
            this.btnVehiclerentings.Name = "btnVehiclerentings";
            this.btnVehiclerentings.Size = new System.Drawing.Size(358, 89);
            this.btnVehiclerentings.TabIndex = 12;
            this.btnVehiclerentings.Text = "Vehicle renting     ";
            this.btnVehiclerentings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehiclerentings.UseVisualStyleBackColor = false;
            this.btnVehiclerentings.Click += new System.EventHandler(this.btnVehiclerentings_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Black;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(859, 524);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(358, 89);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Settings                ";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.buniPanelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnKitchenAndStock
            // 
            this.btnKitchenAndStock.BackColor = System.Drawing.Color.Black;
            this.btnKitchenAndStock.FlatAppearance.BorderSize = 0;
            this.btnKitchenAndStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchenAndStock.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchenAndStock.ForeColor = System.Drawing.Color.White;
            this.btnKitchenAndStock.Image = ((System.Drawing.Image)(resources.GetObject("btnKitchenAndStock.Image")));
            this.btnKitchenAndStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitchenAndStock.Location = new System.Drawing.Point(859, 247);
            this.btnKitchenAndStock.Name = "btnKitchenAndStock";
            this.btnKitchenAndStock.Size = new System.Drawing.Size(358, 89);
            this.btnKitchenAndStock.TabIndex = 14;
            this.btnKitchenAndStock.Text = "Stock Management";
            this.btnKitchenAndStock.UseVisualStyleBackColor = false;
            this.btnKitchenAndStock.Click += new System.EventHandler(this.btnKitchenAndStock_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.btnKitchenAndStock);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnVehiclerentings);
            this.Controls.Add(this.btnAccomodations);
            this.Controls.Add(this.btnCustomerManagement);
            this.Controls.Add(this.btnSupplierManagement);
            this.Controls.Add(this.btnEventManagement);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Controls.Add(this.btnFoodManagement);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buniPanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            this.buniPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel buniPanelTop;
        private System.Windows.Forms.Panel panelMain;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelBottom;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnFoodManagement;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnEventManagement;
        private System.Windows.Forms.Button btnSupplierManagement;
        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Button btnAccomodations;
        private System.Windows.Forms.Button btnVehiclerentings;
        private System.Windows.Forms.Button btnSettings;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnKitchenAndStock;
    }
}

