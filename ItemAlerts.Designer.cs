namespace Sarasi_HMS
{
    partial class ItemAlerts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemAlerts));
            this.gunaItemAlerts = new Guna.UI.WinForms.GunaDataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackItemAlerts = new System.Windows.Forms.Button();
            this.btnExpirednext30 = new System.Windows.Forms.Button();
            this.btnExpired = new System.Windows.Forms.Button();
            this.buniPanelTopStock = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaItemAlerts)).BeginInit();
            this.buniPanelTopStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaItemAlerts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.gunaItemAlerts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaItemAlerts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaItemAlerts.BackgroundColor = System.Drawing.Color.White;
            this.gunaItemAlerts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaItemAlerts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaItemAlerts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaItemAlerts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaItemAlerts.ColumnHeadersHeight = 45;
            this.gunaItemAlerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.category,
            this.addedOn,
            this.expireDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaItemAlerts.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaItemAlerts.EnableHeadersVisualStyles = false;
            this.gunaItemAlerts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.gunaItemAlerts.Location = new System.Drawing.Point(12, 121);
            this.gunaItemAlerts.Name = "gunaItemAlerts";
            this.gunaItemAlerts.RowHeadersVisible = false;
            this.gunaItemAlerts.RowHeadersWidth = 51;
            this.gunaItemAlerts.RowTemplate.Height = 45;
            this.gunaItemAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaItemAlerts.Size = new System.Drawing.Size(1022, 380);
            this.gunaItemAlerts.TabIndex = 0;
            this.gunaItemAlerts.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.gunaItemAlerts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.gunaItemAlerts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaItemAlerts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaItemAlerts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaItemAlerts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaItemAlerts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaItemAlerts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.gunaItemAlerts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gunaItemAlerts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaItemAlerts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaItemAlerts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaItemAlerts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaItemAlerts.ThemeStyle.HeaderStyle.Height = 45;
            this.gunaItemAlerts.ThemeStyle.ReadOnly = false;
            this.gunaItemAlerts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.gunaItemAlerts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaItemAlerts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaItemAlerts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaItemAlerts.ThemeStyle.RowsStyle.Height = 45;
            this.gunaItemAlerts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.gunaItemAlerts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // category
            // 
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            // 
            // addedOn
            // 
            this.addedOn.DataPropertyName = "addedOn";
            this.addedOn.HeaderText = "AddedOn";
            this.addedOn.MinimumWidth = 6;
            this.addedOn.Name = "addedOn";
            // 
            // expireDate
            // 
            this.expireDate.DataPropertyName = "ExpireDate";
            this.expireDate.HeaderText = "ExpireDate";
            this.expireDate.MinimumWidth = 6;
            this.expireDate.Name = "expireDate";
            // 
            // btnBackItemAlerts
            // 
            this.btnBackItemAlerts.BackColor = System.Drawing.Color.Black;
            this.btnBackItemAlerts.FlatAppearance.BorderSize = 0;
            this.btnBackItemAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackItemAlerts.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackItemAlerts.ForeColor = System.Drawing.Color.White;
            this.btnBackItemAlerts.Image = ((System.Drawing.Image)(resources.GetObject("btnBackItemAlerts.Image")));
            this.btnBackItemAlerts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackItemAlerts.Location = new System.Drawing.Point(43, 507);
            this.btnBackItemAlerts.Name = "btnBackItemAlerts";
            this.btnBackItemAlerts.Size = new System.Drawing.Size(194, 60);
            this.btnBackItemAlerts.TabIndex = 19;
            this.btnBackItemAlerts.Text = "    Back";
            this.btnBackItemAlerts.UseVisualStyleBackColor = false;
            this.btnBackItemAlerts.Click += new System.EventHandler(this.btnBackItemAlerts_Click);
            // 
            // btnExpirednext30
            // 
            this.btnExpirednext30.BackColor = System.Drawing.Color.Black;
            this.btnExpirednext30.FlatAppearance.BorderSize = 0;
            this.btnExpirednext30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpirednext30.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpirednext30.ForeColor = System.Drawing.Color.White;
            this.btnExpirednext30.Image = ((System.Drawing.Image)(resources.GetObject("btnExpirednext30.Image")));
            this.btnExpirednext30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpirednext30.Location = new System.Drawing.Point(574, 56);
            this.btnExpirednext30.Name = "btnExpirednext30";
            this.btnExpirednext30.Size = new System.Drawing.Size(321, 59);
            this.btnExpirednext30.TabIndex = 21;
            this.btnExpirednext30.Text = "      Ex-in next30 days";
            this.btnExpirednext30.UseVisualStyleBackColor = false;
            this.btnExpirednext30.Click += new System.EventHandler(this.btnExpirednext30_Click);
            // 
            // btnExpired
            // 
            this.btnExpired.BackColor = System.Drawing.Color.Black;
            this.btnExpired.FlatAppearance.BorderSize = 0;
            this.btnExpired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpired.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpired.ForeColor = System.Drawing.Color.White;
            this.btnExpired.Image = ((System.Drawing.Image)(resources.GetObject("btnExpired.Image")));
            this.btnExpired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpired.Location = new System.Drawing.Point(191, 56);
            this.btnExpired.Name = "btnExpired";
            this.btnExpired.Size = new System.Drawing.Size(261, 59);
            this.btnExpired.TabIndex = 20;
            this.btnExpired.Text = "    Expired";
            this.btnExpired.UseVisualStyleBackColor = false;
            this.btnExpired.Click += new System.EventHandler(this.btnExpired_Click);
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
            this.buniPanelTopStock.Size = new System.Drawing.Size(1044, 37);
            this.buniPanelTopStock.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(993, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // ItemAlerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 570);
            this.Controls.Add(this.buniPanelTopStock);
            this.Controls.Add(this.btnExpirednext30);
            this.Controls.Add(this.btnExpired);
            this.Controls.Add(this.btnBackItemAlerts);
            this.Controls.Add(this.gunaItemAlerts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemAlerts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemAlerts";
            this.Load += new System.EventHandler(this.ItemAlerts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaItemAlerts)).EndInit();
            this.buniPanelTopStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gunaItemAlerts;
        private System.Windows.Forms.Button btnBackItemAlerts;
        private System.Windows.Forms.Button btnExpirednext30;
        private System.Windows.Forms.Button btnExpired;
        private Bunifu.Framework.UI.BunifuGradientPanel buniPanelTopStock;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
    }
}