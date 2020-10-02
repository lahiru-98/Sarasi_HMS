namespace Sarasi_HMS
{
    partial class ItemAlert
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemAlert));
            this.dgvAlerts = new System.Windows.Forms.DataGridView();
            this.btnExpirednext30 = new System.Windows.Forms.Button();
            this.btnExpired = new System.Windows.Forms.Button();
            this.btnLowQ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlerts
            // 
            this.dgvAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlerts.Location = new System.Drawing.Point(87, 99);
            this.dgvAlerts.Name = "dgvAlerts";
            this.dgvAlerts.RowHeadersWidth = 51;
            this.dgvAlerts.RowTemplate.Height = 24;
            this.dgvAlerts.Size = new System.Drawing.Size(795, 371);
            this.dgvAlerts.TabIndex = 19;
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
            this.btnExpirednext30.Location = new System.Drawing.Point(621, 34);
            this.btnExpirednext30.Name = "btnExpirednext30";
            this.btnExpirednext30.Size = new System.Drawing.Size(261, 59);
            this.btnExpirednext30.TabIndex = 18;
            this.btnExpirednext30.Text = "      Ex-in next30 days";
            this.btnExpirednext30.UseVisualStyleBackColor = false;
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
            this.btnExpired.Location = new System.Drawing.Point(354, 34);
            this.btnExpired.Name = "btnExpired";
            this.btnExpired.Size = new System.Drawing.Size(261, 59);
            this.btnExpired.TabIndex = 17;
            this.btnExpired.Text = "    Expired";
            this.btnExpired.UseVisualStyleBackColor = false;
            // 
            // btnLowQ
            // 
            this.btnLowQ.BackColor = System.Drawing.Color.Black;
            this.btnLowQ.FlatAppearance.BorderSize = 0;
            this.btnLowQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowQ.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowQ.ForeColor = System.Drawing.Color.White;
            this.btnLowQ.Image = ((System.Drawing.Image)(resources.GetObject("btnLowQ.Image")));
            this.btnLowQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLowQ.Location = new System.Drawing.Point(87, 34);
            this.btnLowQ.Name = "btnLowQ";
            this.btnLowQ.Size = new System.Drawing.Size(261, 59);
            this.btnLowQ.TabIndex = 16;
            this.btnLowQ.Text = "  Low Quantity";
            this.btnLowQ.UseVisualStyleBackColor = false;
            // 
            // ItemAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvAlerts);
            this.Controls.Add(this.btnExpirednext30);
            this.Controls.Add(this.btnExpired);
            this.Controls.Add(this.btnLowQ);
            this.Name = "ItemAlert";
            this.Size = new System.Drawing.Size(982, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlerts;
        private System.Windows.Forms.Button btnExpirednext30;
        private System.Windows.Forms.Button btnExpired;
        private System.Windows.Forms.Button btnLowQ;
    }
}
