namespace Sarasi_HMS
{
    partial class POSFoodCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSFoodCard));
            this.lblFoodCardID = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.picBoxFood = new System.Windows.Forms.PictureBox();
            this.lblFoodItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoodCardID
            // 
            this.lblFoodCardID.AutoSize = true;
            this.lblFoodCardID.Location = new System.Drawing.Point(135, 191);
            this.lblFoodCardID.Name = "lblFoodCardID";
            this.lblFoodCardID.Size = new System.Drawing.Size(40, 17);
            this.lblFoodCardID.TabIndex = 14;
            this.lblFoodCardID.Text = "dddd";
            this.lblFoodCardID.Visible = false;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodPrice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.ForeColor = System.Drawing.Color.White;
            this.lblFoodPrice.Location = new System.Drawing.Point(83, 207);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(46, 23);
            this.lblFoodPrice.TabIndex = 13;
            this.lblFoodPrice.Text = "350";
            // 
            // picBoxFood
            // 
            this.picBoxFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxFood.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFood.Image")));
            this.picBoxFood.Location = new System.Drawing.Point(0, 0);
            this.picBoxFood.Name = "picBoxFood";
            this.picBoxFood.Size = new System.Drawing.Size(194, 159);
            this.picBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFood.TabIndex = 9;
            this.picBoxFood.TabStop = false;
            this.picBoxFood.Click += new System.EventHandler(this.picBoxFood_Click);
            // 
            // lblFoodItem
            // 
            this.lblFoodItem.AutoSize = true;
            this.lblFoodItem.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodItem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodItem.ForeColor = System.Drawing.Color.White;
            this.lblFoodItem.Location = new System.Drawing.Point(40, 168);
            this.lblFoodItem.Name = "lblFoodItem";
            this.lblFoodItem.Size = new System.Drawing.Size(122, 23);
            this.lblFoodItem.TabIndex = 15;
            this.lblFoodItem.Text = "Mixed Rice";
            // 
            // POSFoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblFoodItem);
            this.Controls.Add(this.lblFoodCardID);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.picBoxFood);
            this.Name = "POSFoodCard";
            this.Size = new System.Drawing.Size(194, 235);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodCardID;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.PictureBox picBoxFood;
        private System.Windows.Forms.Label lblFoodItem;
    }
}
