namespace Sarasi_HMS
{
    partial class testFoodCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testFoodCard));
            this.labelFoodName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.picBoxFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.BackColor = System.Drawing.Color.Transparent;
            this.labelFoodName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoodName.ForeColor = System.Drawing.Color.White;
            this.labelFoodName.Location = new System.Drawing.Point(3, 147);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(122, 23);
            this.labelFoodName.TabIndex = 3;
            this.labelFoodName.Text = "Mixed Rice";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(3, 175);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 23);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "450/=";
            // 
            // picBoxFood
            // 
            this.picBoxFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxFood.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFood.Image")));
            this.picBoxFood.Location = new System.Drawing.Point(0, 0);
            this.picBoxFood.Name = "picBoxFood";
            this.picBoxFood.Size = new System.Drawing.Size(153, 144);
            this.picBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFood.TabIndex = 0;
            this.picBoxFood.TabStop = false;
            // 
            // testFoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.labelFoodName);
            this.Controls.Add(this.picBoxFood);
            this.Name = "testFoodCard";
            this.Size = new System.Drawing.Size(153, 201);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxFood;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.Label lblPrice;
    }
}
