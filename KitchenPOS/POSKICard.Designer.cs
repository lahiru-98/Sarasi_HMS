namespace Sarasi_HMS
{
    partial class POSKICard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSKICard));
            this.lblKitchenItem = new System.Windows.Forms.Label();
            this.lblItemCardID = new System.Windows.Forms.Label();
            this.lblKitchenPrice = new System.Windows.Forms.Label();
            this.picBoxKitchen = new System.Windows.Forms.PictureBox();
            this.lblMeasurementUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKitchen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitchenItem
            // 
            this.lblKitchenItem.AutoSize = true;
            this.lblKitchenItem.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenItem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenItem.ForeColor = System.Drawing.Color.White;
            this.lblKitchenItem.Location = new System.Drawing.Point(40, 170);
            this.lblKitchenItem.Name = "lblKitchenItem";
            this.lblKitchenItem.Size = new System.Drawing.Size(122, 23);
            this.lblKitchenItem.TabIndex = 19;
            this.lblKitchenItem.Text = "Mixed Rice";
            // 
            // lblItemCardID
            // 
            this.lblItemCardID.AutoSize = true;
            this.lblItemCardID.Location = new System.Drawing.Point(135, 193);
            this.lblItemCardID.Name = "lblItemCardID";
            this.lblItemCardID.Size = new System.Drawing.Size(40, 17);
            this.lblItemCardID.TabIndex = 18;
            this.lblItemCardID.Text = "dddd";
            this.lblItemCardID.Visible = false;
            // 
            // lblKitchenPrice
            // 
            this.lblKitchenPrice.AutoSize = true;
            this.lblKitchenPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenPrice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenPrice.ForeColor = System.Drawing.Color.White;
            this.lblKitchenPrice.Location = new System.Drawing.Point(83, 209);
            this.lblKitchenPrice.Name = "lblKitchenPrice";
            this.lblKitchenPrice.Size = new System.Drawing.Size(46, 23);
            this.lblKitchenPrice.TabIndex = 17;
            this.lblKitchenPrice.Text = "350";
            // 
            // picBoxKitchen
            // 
            this.picBoxKitchen.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxKitchen.Image = ((System.Drawing.Image)(resources.GetObject("picBoxKitchen.Image")));
            this.picBoxKitchen.Location = new System.Drawing.Point(0, 0);
            this.picBoxKitchen.Name = "picBoxKitchen";
            this.picBoxKitchen.Size = new System.Drawing.Size(194, 159);
            this.picBoxKitchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxKitchen.TabIndex = 16;
            this.picBoxKitchen.TabStop = false;
            this.picBoxKitchen.Click += new System.EventHandler(this.picBoxKitchen_Click);
            // 
            // lblMeasurementUnit
            // 
            this.lblMeasurementUnit.AutoSize = true;
            this.lblMeasurementUnit.Location = new System.Drawing.Point(44, 89);
            this.lblMeasurementUnit.Name = "lblMeasurementUnit";
            this.lblMeasurementUnit.Size = new System.Drawing.Size(46, 17);
            this.lblMeasurementUnit.TabIndex = 20;
            this.lblMeasurementUnit.Text = "label1";
            this.lblMeasurementUnit.Visible = false;
            // 
            // POSKICard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblMeasurementUnit);
            this.Controls.Add(this.lblKitchenItem);
            this.Controls.Add(this.lblItemCardID);
            this.Controls.Add(this.lblKitchenPrice);
            this.Controls.Add(this.picBoxKitchen);
            this.Name = "POSKICard";
            this.Size = new System.Drawing.Size(194, 235);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKitchen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitchenItem;
        private System.Windows.Forms.Label lblItemCardID;
        private System.Windows.Forms.Label lblKitchenPrice;
        private System.Windows.Forms.PictureBox picBoxKitchen;
        private System.Windows.Forms.Label lblMeasurementUnit;
    }
}
