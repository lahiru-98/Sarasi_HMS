namespace Sarasi_HMS
{
    partial class vehicleCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehicleCard));
            this.lblFoodCardID = new System.Windows.Forms.Label();
            this.lblVNumber = new System.Windows.Forms.Label();
            this.lblVCardID = new System.Windows.Forms.Label();
            this.lblvtype = new System.Windows.Forms.Label();
            this.lblRentPerday = new System.Windows.Forms.Label();
            this.lblRentperKM = new System.Windows.Forms.Label();
            this.picBoxvehicle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxvehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoodCardID
            // 
            this.lblFoodCardID.AutoSize = true;
            this.lblFoodCardID.Location = new System.Drawing.Point(135, 220);
            this.lblFoodCardID.Name = "lblFoodCardID";
            this.lblFoodCardID.Size = new System.Drawing.Size(0, 17);
            this.lblFoodCardID.TabIndex = 14;
            this.lblFoodCardID.Visible = false;
            // 
            // lblVNumber
            // 
            this.lblVNumber.AutoSize = true;
            this.lblVNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblVNumber.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVNumber.ForeColor = System.Drawing.Color.White;
            this.lblVNumber.Location = new System.Drawing.Point(52, 182);
            this.lblVNumber.Name = "lblVNumber";
            this.lblVNumber.Size = new System.Drawing.Size(118, 23);
            this.lblVNumber.TabIndex = 10;
            this.lblVNumber.Text = "#########";
            // 
            // lblVCardID
            // 
            this.lblVCardID.AutoSize = true;
            this.lblVCardID.Location = new System.Drawing.Point(176, 220);
            this.lblVCardID.Name = "lblVCardID";
            this.lblVCardID.Size = new System.Drawing.Size(46, 17);
            this.lblVCardID.TabIndex = 15;
            this.lblVCardID.Text = "label1";
            this.lblVCardID.Visible = false;
            // 
            // lblvtype
            // 
            this.lblvtype.AutoSize = true;
            this.lblvtype.BackColor = System.Drawing.Color.Transparent;
            this.lblvtype.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvtype.ForeColor = System.Drawing.Color.White;
            this.lblvtype.Location = new System.Drawing.Point(52, 220);
            this.lblvtype.Name = "lblvtype";
            this.lblvtype.Size = new System.Drawing.Size(118, 23);
            this.lblvtype.TabIndex = 16;
            this.lblvtype.Text = "#########";
            // 
            // lblRentPerday
            // 
            this.lblRentPerday.AutoSize = true;
            this.lblRentPerday.BackColor = System.Drawing.Color.Transparent;
            this.lblRentPerday.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentPerday.ForeColor = System.Drawing.Color.White;
            this.lblRentPerday.Location = new System.Drawing.Point(3, 270);
            this.lblRentPerday.Name = "lblRentPerday";
            this.lblRentPerday.Size = new System.Drawing.Size(118, 23);
            this.lblRentPerday.TabIndex = 17;
            this.lblRentPerday.Text = "#########";
            // 
            // lblRentperKM
            // 
            this.lblRentperKM.AutoSize = true;
            this.lblRentperKM.BackColor = System.Drawing.Color.Transparent;
            this.lblRentperKM.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentperKM.ForeColor = System.Drawing.Color.White;
            this.lblRentperKM.Location = new System.Drawing.Point(160, 270);
            this.lblRentperKM.Name = "lblRentperKM";
            this.lblRentperKM.Size = new System.Drawing.Size(82, 23);
            this.lblRentperKM.TabIndex = 18;
            this.lblRentperKM.Text = "######";
            // 
            // picBoxvehicle
            // 
            this.picBoxvehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxvehicle.Image = ((System.Drawing.Image)(resources.GetObject("picBoxvehicle.Image")));
            this.picBoxvehicle.Location = new System.Drawing.Point(0, 0);
            this.picBoxvehicle.Name = "picBoxvehicle";
            this.picBoxvehicle.Size = new System.Drawing.Size(245, 179);
            this.picBoxvehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxvehicle.TabIndex = 9;
            this.picBoxvehicle.TabStop = false;
            this.picBoxvehicle.Click += new System.EventHandler(this.picBoxvehicle_Click);
            // 
            // vehicleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblRentperKM);
            this.Controls.Add(this.lblRentPerday);
            this.Controls.Add(this.lblvtype);
            this.Controls.Add(this.lblVCardID);
            this.Controls.Add(this.lblFoodCardID);
            this.Controls.Add(this.lblVNumber);
            this.Controls.Add(this.picBoxvehicle);
            this.Name = "vehicleCard";
            this.Size = new System.Drawing.Size(245, 305);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxvehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodCardID;
        private System.Windows.Forms.Label lblVNumber;
        private System.Windows.Forms.PictureBox picBoxvehicle;
        private System.Windows.Forms.Label lblVCardID;
        private System.Windows.Forms.Label lblvtype;
        private System.Windows.Forms.Label lblRentPerday;
        private System.Windows.Forms.Label lblRentperKM;
    }
}
