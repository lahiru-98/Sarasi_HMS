namespace Sarasi_HMS
{
    partial class ItemCategoryButton
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
            this.txtICBtnCategoryID = new System.Windows.Forms.Label();
            this.txtCategoryButtonName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtICBtnCategoryID
            // 
            this.txtICBtnCategoryID.AutoSize = true;
            this.txtICBtnCategoryID.Location = new System.Drawing.Point(165, 34);
            this.txtICBtnCategoryID.Name = "txtICBtnCategoryID";
            this.txtICBtnCategoryID.Size = new System.Drawing.Size(0, 17);
            this.txtICBtnCategoryID.TabIndex = 3;
            this.txtICBtnCategoryID.Visible = false;
            // 
            // txtCategoryButtonName
            // 
            this.txtCategoryButtonName.AutoSize = true;
            this.txtCategoryButtonName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryButtonName.Location = new System.Drawing.Point(25, 11);
            this.txtCategoryButtonName.Name = "txtCategoryButtonName";
            this.txtCategoryButtonName.Size = new System.Drawing.Size(164, 23);
            this.txtCategoryButtonName.TabIndex = 2;
            this.txtCategoryButtonName.Text = "CategoryNAme";
            // 
            // ItemCategoryButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Controls.Add(this.txtICBtnCategoryID);
            this.Controls.Add(this.txtCategoryButtonName);
            this.Name = "ItemCategoryButton";
            this.Size = new System.Drawing.Size(224, 61);
            this.Click += new System.EventHandler(this.ItemCategoryButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtICBtnCategoryID;
        private System.Windows.Forms.Label txtCategoryButtonName;
    }
}
