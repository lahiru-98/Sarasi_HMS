namespace Sarasi_HMS
{
    partial class testOrderAlerts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testOrderAlerts));
            this.lblItems = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBoxOrder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.Transparent;
            this.lblItems.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.ForeColor = System.Drawing.Color.White;
            this.lblItems.Location = new System.Drawing.Point(13, 141);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(110, 21);
            this.lblItems.TabIndex = 3;
            this.lblItems.Text = "User Name";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(18, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 39);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Served";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // pictureBoxOrder
            // 
            this.pictureBoxOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxOrder.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrder.Image")));
            this.pictureBoxOrder.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOrder.Name = "pictureBoxOrder";
            this.pictureBoxOrder.Size = new System.Drawing.Size(174, 128);
            this.pictureBoxOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrder.TabIndex = 0;
            this.pictureBoxOrder.TabStop = false;
            // 
            // testOrderAlerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.pictureBoxOrder);
            this.Name = "testOrderAlerts";
            this.Size = new System.Drawing.Size(174, 238);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOrder;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Button btnClear;
    }
}
