namespace Sarasi_HMS
{
    partial class BillItemRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillItemRow));
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblbillrowId = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSubstract = new System.Windows.Forms.PictureBox();
            this.btnAddition = new System.Windows.Forms.PictureBox();
            this.lblmeasurementunit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubstract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddition)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(122, 1);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(46, 17);
            this.lblPurchasePrice.TabIndex = 18;
            this.lblPurchasePrice.Text = "label1";
            this.lblPurchasePrice.Visible = false;
            // 
            // lblbillrowId
            // 
            this.lblbillrowId.AutoSize = true;
            this.lblbillrowId.Location = new System.Drawing.Point(136, 34);
            this.lblbillrowId.Name = "lblbillrowId";
            this.lblbillrowId.Size = new System.Drawing.Size(0, 17);
            this.lblbillrowId.TabIndex = 17;
            this.lblbillrowId.Visible = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(283, 16);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(63, 23);
            this.lblSubTotal.TabIndex = 14;
            this.lblSubTotal.Text = "Total";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(184, 16);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(22, 23);
            this.lblQty.TabIndex = 13;
            this.lblQty.Text = "#";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(8, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 23);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Mixed Rice";
            // 
            // btnSubstract
            // 
            this.btnSubstract.Image = ((System.Drawing.Image)(resources.GetObject("btnSubstract.Image")));
            this.btnSubstract.Location = new System.Drawing.Point(411, 8);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(37, 38);
            this.btnSubstract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSubstract.TabIndex = 16;
            this.btnSubstract.TabStop = false;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Image = ((System.Drawing.Image)(resources.GetObject("btnAddition.Image")));
            this.btnAddition.Location = new System.Drawing.Point(466, 8);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(37, 38);
            this.btnAddition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddition.TabIndex = 15;
            this.btnAddition.TabStop = false;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // lblmeasurementunit
            // 
            this.lblmeasurementunit.AutoSize = true;
            this.lblmeasurementunit.BackColor = System.Drawing.Color.Transparent;
            this.lblmeasurementunit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmeasurementunit.ForeColor = System.Drawing.Color.White;
            this.lblmeasurementunit.Location = new System.Drawing.Point(212, 16);
            this.lblmeasurementunit.Name = "lblmeasurementunit";
            this.lblmeasurementunit.Size = new System.Drawing.Size(39, 23);
            this.lblmeasurementunit.TabIndex = 19;
            this.lblmeasurementunit.Text = "Kg";
            // 
            // BillItemRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblmeasurementunit);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblbillrowId);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "BillItemRow";
            this.Size = new System.Drawing.Size(511, 53);
            ((System.ComponentModel.ISupportInitialize)(this.btnSubstract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblbillrowId;
        private System.Windows.Forms.PictureBox btnSubstract;
        private System.Windows.Forms.PictureBox btnAddition;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblmeasurementunit;
    }
}
