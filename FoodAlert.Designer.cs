namespace Sarasi_HMS
{
    partial class FoodAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodAlert));
            this.btnExpired = new System.Windows.Forms.Button();
            this.btnExpirednext30 = new System.Windows.Forms.Button();
            this.dgvAlerts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            this.SuspendLayout();
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
            this.btnExpired.Location = new System.Drawing.Point(137, 19);
            this.btnExpired.Name = "btnExpired";
            this.btnExpired.Size = new System.Drawing.Size(261, 59);
            this.btnExpired.TabIndex = 13;
            this.btnExpired.Text = "    Expired";
            this.btnExpired.UseVisualStyleBackColor = false;
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
            this.btnExpirednext30.Location = new System.Drawing.Point(521, 19);
            this.btnExpirednext30.Name = "btnExpirednext30";
            this.btnExpirednext30.Size = new System.Drawing.Size(261, 59);
            this.btnExpirednext30.TabIndex = 14;
            this.btnExpirednext30.Text = "      Ex-in next30 days";
            this.btnExpirednext30.UseVisualStyleBackColor = false;
            // 
            // dgvAlerts
            // 
            this.dgvAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlerts.Location = new System.Drawing.Point(88, 97);
            this.dgvAlerts.Name = "dgvAlerts";
            this.dgvAlerts.RowHeadersWidth = 51;
            this.dgvAlerts.RowTemplate.Height = 24;
            this.dgvAlerts.Size = new System.Drawing.Size(801, 377);
            this.dgvAlerts.TabIndex = 15;
            // 
            // FoodAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvAlerts);
            this.Controls.Add(this.btnExpirednext30);
            this.Controls.Add(this.btnExpired);
            this.Name = "FoodAlert";
            this.Size = new System.Drawing.Size(982, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExpired;
        private System.Windows.Forms.Button btnExpirednext30;
        private System.Windows.Forms.DataGridView dgvAlerts;
    }
}
