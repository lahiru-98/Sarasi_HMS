using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasi_HMS.userControls
{
    public partial class ItemCategoryCard : UserControl
    {
        public ItemCategoryCard()
        {
            InitializeComponent();
        }


        public String cardId
        {
            get { return txtItemCID.Text; }
            set { txtItemCID.Text = value; }
        }

        public String categoryName
        {
            get { return lblItemCName.Text; }
            set { lblItemCName.Text = value; }
        }

        public String categorydescription
        {
            get { return lblItemCdescription.Text; }
            set { lblItemCdescription.Text = value; }
        }

        private void btnItemCEdit_Click(object sender, EventArgs e)
        {
            //getting the card id 
            String cardId = this.txtItemCID.Text;
            AddItemCategory addItemCategory = AddItemCategory.getInstance();
            addItemCategory.editcategory(cardId);
            addItemCategory.Show();
            this.Hide();
        }

        private void btnItemCDelete_Click(object sender, EventArgs e)
        {
            String cardID = this.txtItemCID.Text; //getting the cliked card id 

            ItemCategories item_categories = ItemCategories.getInstance();
            item_categories.deleteCategory(cardID); //passing the Id 
        }
    }
}
