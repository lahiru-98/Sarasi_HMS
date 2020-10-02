using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasi_HMS
{
    public partial class CategoryCard : UserControl
    {
        public CategoryCard()
        {
            InitializeComponent();
        }

        public String cardId
        {
            get { return txtCardID.Text; }
            set { txtCardID.Text = value; }
        }

        public String categoryName
        {
            get { return lblCName.Text; }
            set { lblCName.Text = value; }
        }

        public String categorydescription
        {
            get { return lblCdescription.Text; }
            set { lblCdescription.Text = value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //getting the card id 
            String cardId = this.txtCardID.Text;
            AddFoodCategory addFoodcategory = AddFoodCategory.getInstance();
            addFoodcategory.editcategory(cardId);
            addFoodcategory.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String cardID = this.txtCardID.Text; //getting the cliked card id 

            Categories categories = Categories.getInstance();
            categories.deleteCategory(cardID); //passing the Id 


        }

        private void CategoryCard_Load(object sender, EventArgs e)
        {

        }
    }


}
