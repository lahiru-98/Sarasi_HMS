namespace Sarasi_HMS
{
    partial class FoodItemCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodItemCard));
            this.lblFoodItem = new System.Windows.Forms.Label();
            this.btnEditfoodCard = new System.Windows.Forms.PictureBox();
            this.btndeleteFoodCard = new System.Windows.Forms.PictureBox();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblFoodCardID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditfoodCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndeleteFoodCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoodItem
            // 
            this.lblFoodItem.AutoSize = true;
            this.lblFoodItem.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodItem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodItem.ForeColor = System.Drawing.Color.White;
            this.lblFoodItem.Location = new System.Drawing.Point(7, 168);
            this.lblFoodItem.Name = "lblFoodItem";
            this.lblFoodItem.Size = new System.Drawing.Size(122, 23);
            this.lblFoodItem.TabIndex = 4;
            this.lblFoodItem.Text = "Mixed Rice";
            // 
            // btnEditfoodCard
            // 
            this.btnEditfoodCard.Image = ((System.Drawing.Image)(resources.GetObject("btnEditfoodCard.Image")));
            this.btnEditfoodCard.Location = new System.Drawing.Point(106, 209);
            this.btnEditfoodCard.Name = "btnEditfoodCard";
            this.btnEditfoodCard.Size = new System.Drawing.Size(37, 33);
            this.btnEditfoodCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditfoodCard.TabIndex = 6;
            this.btnEditfoodCard.TabStop = false;
            this.btnEditfoodCard.Click += new System.EventHandler(this.btnEditfoodCard_Click);
            // 
            // btndeleteFoodCard
            // 
            this.btndeleteFoodCard.Image = ((System.Drawing.Image)(resources.GetObject("btndeleteFoodCard.Image")));
            this.btndeleteFoodCard.Location = new System.Drawing.Point(149, 209);
            this.btndeleteFoodCard.Name = "btndeleteFoodCard";
            this.btndeleteFoodCard.Size = new System.Drawing.Size(33, 35);
            this.btndeleteFoodCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btndeleteFoodCard.TabIndex = 5;
            this.btndeleteFoodCard.TabStop = false;
            this.btndeleteFoodCard.Click += new System.EventHandler(this.btndeleteFoodCard_Click);
            // 
            // picFood
            // 
            this.picFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.picFood.Image = ((System.Drawing.Image)(resources.GetObject("picFood.Image")));
            this.picFood.Location = new System.Drawing.Point(0, 0);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(185, 159);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFood.TabIndex = 0;
            this.picFood.TabStop = false;
            this.picFood.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picFood_MouseClick);
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodPrice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.ForeColor = System.Drawing.Color.White;
            this.lblFoodPrice.Location = new System.Drawing.Point(7, 209);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(46, 23);
            this.lblFoodPrice.TabIndex = 7;
            this.lblFoodPrice.Text = "350";
            // 
            // lblFoodCardID
            // 
            this.lblFoodCardID.AutoSize = true;
            this.lblFoodCardID.Location = new System.Drawing.Point(135, 189);
            this.lblFoodCardID.Name = "lblFoodCardID";
            this.lblFoodCardID.Size = new System.Drawing.Size(0, 17);
            this.lblFoodCardID.TabIndex = 8;
            this.lblFoodCardID.Visible = false;
            // 
            // FoodItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblFoodCardID);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.btnEditfoodCard);
            this.Controls.Add(this.btndeleteFoodCard);
            this.Controls.Add(this.lblFoodItem);
            this.Controls.Add(this.picFood);
            this.Name = "FoodItemCard";
            this.Size = new System.Drawing.Size(185, 247);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditfoodCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndeleteFoodCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Label lblFoodItem;
        private System.Windows.Forms.PictureBox btndeleteFoodCard;
        private System.Windows.Forms.PictureBox btnEditfoodCard;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Label lblFoodCardID;
    }
}
