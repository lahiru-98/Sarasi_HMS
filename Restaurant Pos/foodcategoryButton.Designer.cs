namespace Sarasi_HMS
{
    partial class foodcategoryButton
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
            this.txtCategoryButtonName = new System.Windows.Forms.Label();
            this.txtFCBtnCategoryID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCategoryButtonName
            // 
            this.txtCategoryButtonName.AutoSize = true;
            this.txtCategoryButtonName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryButtonName.Location = new System.Drawing.Point(24, 14);
            this.txtCategoryButtonName.Name = "txtCategoryButtonName";
            this.txtCategoryButtonName.Size = new System.Drawing.Size(164, 23);
            this.txtCategoryButtonName.TabIndex = 0;
            this.txtCategoryButtonName.Text = "CategoryNAme";
            // 
            // txtFCBtnCategoryID
            // 
            this.txtFCBtnCategoryID.AutoSize = true;
            this.txtFCBtnCategoryID.Location = new System.Drawing.Point(173, 37);
            this.txtFCBtnCategoryID.Name = "txtFCBtnCategoryID";
            this.txtFCBtnCategoryID.Size = new System.Drawing.Size(0, 17);
            this.txtFCBtnCategoryID.TabIndex = 1;
            this.txtFCBtnCategoryID.Visible = false;
            // 
            // foodcategoryButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtFCBtnCategoryID);
            this.Controls.Add(this.txtCategoryButtonName);
            this.Name = "foodcategoryButton";
            this.Size = new System.Drawing.Size(222, 54);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.foodcategoryButton_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCategoryButtonName;
        private System.Windows.Forms.Label txtFCBtnCategoryID;
    }
}
