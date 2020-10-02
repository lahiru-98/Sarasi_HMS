namespace Sarasi_HMS
{
    partial class kitchenPOSSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.KitchenposThemeSelector = new System.Windows.Forms.ComboBox();
            this.btnKitchenposSettingOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Theme";
            // 
            // KitchenposThemeSelector
            // 
            this.KitchenposThemeSelector.FormattingEnabled = true;
            this.KitchenposThemeSelector.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.KitchenposThemeSelector.Location = new System.Drawing.Point(56, 66);
            this.KitchenposThemeSelector.Name = "KitchenposThemeSelector";
            this.KitchenposThemeSelector.Size = new System.Drawing.Size(222, 24);
            this.KitchenposThemeSelector.TabIndex = 6;
            this.KitchenposThemeSelector.SelectedIndexChanged += new System.EventHandler(this.KitchenposThemeSelector_SelectedIndexChanged);
            // 
            // btnKitchenposSettingOK
            // 
            this.btnKitchenposSettingOK.BackColor = System.Drawing.Color.Transparent;
            this.btnKitchenposSettingOK.FlatAppearance.BorderSize = 2;
            this.btnKitchenposSettingOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnKitchenposSettingOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnKitchenposSettingOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchenposSettingOK.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchenposSettingOK.ForeColor = System.Drawing.Color.White;
            this.btnKitchenposSettingOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitchenposSettingOK.Location = new System.Drawing.Point(101, 110);
            this.btnKitchenposSettingOK.Name = "btnKitchenposSettingOK";
            this.btnKitchenposSettingOK.Size = new System.Drawing.Size(135, 35);
            this.btnKitchenposSettingOK.TabIndex = 17;
            this.btnKitchenposSettingOK.Text = "Ok";
            this.btnKitchenposSettingOK.UseVisualStyleBackColor = false;
            this.btnKitchenposSettingOK.Click += new System.EventHandler(this.btnKitchenposSettingOK_Click);
            // 
            // kitchenPOSSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(334, 157);
            this.Controls.Add(this.btnKitchenposSettingOK);
            this.Controls.Add(this.KitchenposThemeSelector);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitchenPOSSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitchenPOSSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox KitchenposThemeSelector;
        private System.Windows.Forms.Button btnKitchenposSettingOK;
    }
}