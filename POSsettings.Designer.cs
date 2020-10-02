namespace Sarasi_HMS
{
    partial class POSsettings
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
            this.posThemeSelector = new System.Windows.Forms.ComboBox();
            this.btnposSettingOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Theme";
            // 
            // posThemeSelector
            // 
            this.posThemeSelector.FormattingEnabled = true;
            this.posThemeSelector.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.posThemeSelector.Location = new System.Drawing.Point(72, 95);
            this.posThemeSelector.Name = "posThemeSelector";
            this.posThemeSelector.Size = new System.Drawing.Size(222, 24);
            this.posThemeSelector.TabIndex = 5;
            this.posThemeSelector.SelectedIndexChanged += new System.EventHandler(this.posThemeSelector_SelectedIndexChanged);
            // 
            // btnposSettingOK
            // 
            this.btnposSettingOK.BackColor = System.Drawing.Color.Transparent;
            this.btnposSettingOK.FlatAppearance.BorderSize = 2;
            this.btnposSettingOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnposSettingOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnposSettingOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnposSettingOK.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnposSettingOK.ForeColor = System.Drawing.Color.White;
            this.btnposSettingOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnposSettingOK.Location = new System.Drawing.Point(114, 150);
            this.btnposSettingOK.Name = "btnposSettingOK";
            this.btnposSettingOK.Size = new System.Drawing.Size(135, 35);
            this.btnposSettingOK.TabIndex = 16;
            this.btnposSettingOK.Text = "Ok";
            this.btnposSettingOK.UseVisualStyleBackColor = false;
            this.btnposSettingOK.Click += new System.EventHandler(this.btnposSettingOK_Click);
            // 
            // POSsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(352, 204);
            this.Controls.Add(this.btnposSettingOK);
            this.Controls.Add(this.posThemeSelector);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSsettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSsettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox posThemeSelector;
        private System.Windows.Forms.Button btnposSettingOK;
    }
}