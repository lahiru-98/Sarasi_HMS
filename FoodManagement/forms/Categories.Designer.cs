namespace Sarasi_HMS
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.label1 = new System.Windows.Forms.Label();
            this.flowFoodCategoryList = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddnewCategory = new System.Windows.Forms.PictureBox();
            this.buniPanelTopAddFood = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddnewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Food Category list";
            // 
            // flowFoodCategoryList
            // 
            this.flowFoodCategoryList.AutoScroll = true;
            this.flowFoodCategoryList.Location = new System.Drawing.Point(12, 93);
            this.flowFoodCategoryList.Name = "flowFoodCategoryList";
            this.flowFoodCategoryList.Size = new System.Drawing.Size(834, 394);
            this.flowFoodCategoryList.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Add new";
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
            this.btnBack.Location = new System.Drawing.Point(240, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 52);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddnewCategory
            // 
            this.btnAddnewCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddnewCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddnewCategory.Image")));
            this.btnAddnewCategory.Location = new System.Drawing.Point(780, 38);
            this.btnAddnewCategory.Name = "btnAddnewCategory";
            this.btnAddnewCategory.Size = new System.Drawing.Size(45, 40);
            this.btnAddnewCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddnewCategory.TabIndex = 28;
            this.btnAddnewCategory.TabStop = false;
            this.btnAddnewCategory.Click += new System.EventHandler(this.btnAddnewCategory_Click);
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
            this.buniPanelTopAddFood.Size = new System.Drawing.Size(871, 18);
            this.buniPanelTopAddFood.TabIndex = 26;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(871, 570);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddnewCategory);
            this.Controls.Add(this.flowFoodCategoryList);
            this.Controls.Add(this.buniPanelTopAddFood);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddnewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel buniPanelTopAddFood;
        private System.Windows.Forms.FlowLayoutPanel flowFoodCategoryList;
        private System.Windows.Forms.PictureBox btnAddnewCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}