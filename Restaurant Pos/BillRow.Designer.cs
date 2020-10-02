namespace Sarasi_HMS
{
    partial class BillRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillRow));
            this.lblName = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.PictureBox();
            this.btnSubstract = new System.Windows.Forms.PictureBox();
            this.lblbillrowId = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubstract)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(11, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Mixed Rice";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(178, 15);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(43, 23);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "qty";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(287, 15);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(63, 23);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "Total";
            // 
            // btnAddition
            // 
            this.btnAddition.Image = ((System.Drawing.Image)(resources.GetObject("btnAddition.Image")));
            this.btnAddition.Location = new System.Drawing.Point(470, 7);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(37, 38);
            this.btnAddition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddition.TabIndex = 8;
            this.btnAddition.TabStop = false;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Image = ((System.Drawing.Image)(resources.GetObject("btnSubstract.Image")));
            this.btnSubstract.Location = new System.Drawing.Point(415, 7);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(37, 38);
            this.btnSubstract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSubstract.TabIndex = 9;
            this.btnSubstract.TabStop = false;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // lblbillrowId
            // 
            this.lblbillrowId.AutoSize = true;
            this.lblbillrowId.Location = new System.Drawing.Point(140, 33);
            this.lblbillrowId.Name = "lblbillrowId";
            this.lblbillrowId.Size = new System.Drawing.Size(0, 17);
            this.lblbillrowId.TabIndex = 10;
            this.lblbillrowId.Visible = false;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(126, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(46, 17);
            this.lblUnitPrice.TabIndex = 11;
            this.lblUnitPrice.Text = "label1";
            this.lblUnitPrice.Visible = false;
            // 
            // BillRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblbillrowId);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblName);
            this.Name = "BillRow";
            this.Size = new System.Drawing.Size(511, 53);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubstract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.PictureBox btnAddition;
        private System.Windows.Forms.PictureBox btnSubstract;
        private System.Windows.Forms.Label lblbillrowId;
        private System.Windows.Forms.Label lblUnitPrice;
    }
}
