namespace Sarasi_HMS
{
    partial class ItemCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCategories));
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowItemCategoryList = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddnewItemCategory = new System.Windows.Forms.PictureBox();
            this.buniPanelTopAddFood = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddnewItemCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(129, 482);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 52);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Add new";
            // 
            // flowItemCategoryList
            // 
            this.flowItemCategoryList.AutoScroll = true;
            this.flowItemCategoryList.Location = new System.Drawing.Point(12, 70);
            this.flowItemCategoryList.Name = "flowItemCategoryList";
            this.flowItemCategoryList.Size = new System.Drawing.Size(834, 394);
            this.flowItemCategoryList.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Item Category list";
            // 
            // btnAddnewItemCategory
            // 
            this.btnAddnewItemCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddnewItemCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddnewItemCategory.Image")));
            this.btnAddnewItemCategory.Location = new System.Drawing.Point(732, 16);
            this.btnAddnewItemCategory.Name = "btnAddnewItemCategory";
            this.btnAddnewItemCategory.Size = new System.Drawing.Size(45, 40);
            this.btnAddnewItemCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddnewItemCategory.TabIndex = 34;
            this.btnAddnewItemCategory.TabStop = false;
            this.btnAddnewItemCategory.Click += new System.EventHandler(this.btnAddnewItemCategory_Click);
            // 
            // buniPanelTopAddFood
            // 
            this.buniPanelTopAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buniPanelTopAddFood.BackgroundImage")));
            this.buniPanelTopAddFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniPanelTopAddFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.buniPanelTopAddFood.GradientBottomLeft = System.Drawing.Color.SaddleBrown;
            this.buniPanelTopAddFood.GradientBottomRight = System.Drawing.Color.White;
            this.buniPanelTopAddFood.GradientTopLeft = System.Drawing.Color.Gold;
            this.buniPanelTopAddFood.GradientTopRight = System.Drawing.Color.White;
            this.buniPanelTopAddFood.Location = new System.Drawing.Point(0, 0);
            this.buniPanelTopAddFood.Name = "buniPanelTopAddFood";
            this.buniPanelTopAddFood.Quality = 10;
            this.buniPanelTopAddFood.Size = new System.Drawing.Size(883, 18);
            this.buniPanelTopAddFood.TabIndex = 32;
            // 
            // ItemCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 555);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddnewItemCategory);
            this.Controls.Add(this.flowItemCategoryList);
            this.Controls.Add(this.buniPanelTopAddFood);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemCategories";
            this.Load += new System.EventHandler(this.ItemCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddnewItemCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnAddnewItemCategory;
        private System.Windows.Forms.FlowLayoutPanel flowItemCategoryList;
        private Bunifu.Framework.UI.BunifuGradientPanel buniPanelTopAddFood;
        private System.Windows.Forms.Label label1;
    }
}