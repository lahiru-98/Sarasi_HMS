namespace Sarasi_HMS
{
    partial class KitchenitemCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenitemCard));
            this.lblKitchenpurchaseprice = new System.Windows.Forms.Label();
            this.lblKitchenitemname = new System.Windows.Forms.Label();
            this.lblItemId = new System.Windows.Forms.Label();
            this.btnEditItemCard = new System.Windows.Forms.PictureBox();
            this.btndeleteItemCard = new System.Windows.Forms.PictureBox();
            this.picBoxKitchenitem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditItemCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndeleteItemCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKitchenitem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitchenpurchaseprice
            // 
            this.lblKitchenpurchaseprice.AutoSize = true;
            this.lblKitchenpurchaseprice.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenpurchaseprice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenpurchaseprice.ForeColor = System.Drawing.Color.White;
            this.lblKitchenpurchaseprice.Location = new System.Drawing.Point(18, 216);
            this.lblKitchenpurchaseprice.Name = "lblKitchenpurchaseprice";
            this.lblKitchenpurchaseprice.Size = new System.Drawing.Size(46, 23);
            this.lblKitchenpurchaseprice.TabIndex = 11;
            this.lblKitchenpurchaseprice.Text = "350";
            // 
            // lblKitchenitemname
            // 
            this.lblKitchenitemname.AutoSize = true;
            this.lblKitchenitemname.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenitemname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenitemname.ForeColor = System.Drawing.Color.White;
            this.lblKitchenitemname.Location = new System.Drawing.Point(18, 175);
            this.lblKitchenitemname.Name = "lblKitchenitemname";
            this.lblKitchenitemname.Size = new System.Drawing.Size(122, 23);
            this.lblKitchenitemname.TabIndex = 8;
            this.lblKitchenitemname.Text = "Mixed Rice";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(147, 181);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(46, 17);
            this.lblItemId.TabIndex = 12;
            this.lblItemId.Text = "label1";
            this.lblItemId.Visible = false;
            // 
            // btnEditItemCard
            // 
            this.btnEditItemCard.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItemCard.Image")));
            this.btnEditItemCard.Location = new System.Drawing.Point(117, 216);
            this.btnEditItemCard.Name = "btnEditItemCard";
            this.btnEditItemCard.Size = new System.Drawing.Size(37, 33);
            this.btnEditItemCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditItemCard.TabIndex = 10;
            this.btnEditItemCard.TabStop = false;
            this.btnEditItemCard.Click += new System.EventHandler(this.btnEditItemCard_Click);
            // 
            // btndeleteItemCard
            // 
            this.btndeleteItemCard.Image = ((System.Drawing.Image)(resources.GetObject("btndeleteItemCard.Image")));
            this.btndeleteItemCard.Location = new System.Drawing.Point(160, 216);
            this.btndeleteItemCard.Name = "btndeleteItemCard";
            this.btndeleteItemCard.Size = new System.Drawing.Size(33, 35);
            this.btndeleteItemCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btndeleteItemCard.TabIndex = 9;
            this.btndeleteItemCard.TabStop = false;
            this.btndeleteItemCard.Click += new System.EventHandler(this.btndeleteItemCard_Click);
            // 
            // picBoxKitchenitem
            // 
            this.picBoxKitchenitem.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxKitchenitem.Location = new System.Drawing.Point(0, 0);
            this.picBoxKitchenitem.Name = "picBoxKitchenitem";
            this.picBoxKitchenitem.Size = new System.Drawing.Size(205, 172);
            this.picBoxKitchenitem.TabIndex = 13;
            this.picBoxKitchenitem.TabStop = false;
            this.picBoxKitchenitem.Click += new System.EventHandler(this.picBoxKitchenitem_Click);
            // 
            // KitchenitemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.picBoxKitchenitem);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.lblKitchenpurchaseprice);
            this.Controls.Add(this.btnEditItemCard);
            this.Controls.Add(this.btndeleteItemCard);
            this.Controls.Add(this.lblKitchenitemname);
            this.Name = "KitchenitemCard";
            this.Size = new System.Drawing.Size(205, 265);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditItemCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndeleteItemCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKitchenitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKitchenpurchaseprice;
        private System.Windows.Forms.PictureBox btnEditItemCard;
        private System.Windows.Forms.PictureBox btndeleteItemCard;
        private System.Windows.Forms.Label lblKitchenitemname;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.PictureBox picBoxKitchenitem;
    }
}
