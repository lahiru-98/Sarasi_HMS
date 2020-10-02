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
    public partial class FoodItemCard : UserControl
    {
        public FoodItemCard()
        {
            InitializeComponent();
        }


        public Image FoodImage
        {
            get { return picFood.Image; }
            set { picFood.Image = value; }
        }
        public String FoodName
        {
            get { return lblFoodItem.Text; }
            set { lblFoodItem.Text = value; }
        }

        public String price
        {
            get { return lblFoodPrice.Text; }
            set { lblFoodPrice.Text = value; }
        }

        public String cardId
        {
            get { return lblFoodCardID.Text; }
            set { lblFoodCardID.Text = value; }
        }

        private void picFood_MouseClick(object sender, MouseEventArgs e)
        {
            //what to do when click on the card picture 
            MessageBox.Show("card clicked - id = " + cardId);
        }

        private void btnEditfoodCard_Click(object sender, EventArgs e)
        {
            //getting the card id 
            String cardId = this.cardId;
            AddNewFood addNwFood = AddNewFood.getInstance();
            addNwFood.editcategory(cardId);
            addNwFood.Show();
            this.Hide();
        }

        private void btndeleteFoodCard_Click(object sender, EventArgs e)
        {
            String cardID = this.cardId; //getting the cliked card id 

            FoodManagement foodManagement = FoodManagement.getInstance();
            foodManagement.deleteFood(cardID); //passing the Id 
        }
    }
}
