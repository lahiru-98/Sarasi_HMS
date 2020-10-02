using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Sarasi_HMS
{
    public partial class foodcategoryButton : UserControl
    {
        public foodcategoryButton()
        {
            InitializeComponent();
        }

        public String ButtonName
        {
            get { return txtCategoryButtonName.Text; }
            set { txtCategoryButtonName.Text = value; }
        }

        public String ButtonID
        {
            get { return txtFCBtnCategoryID.Text; }
            set { txtFCBtnCategoryID.Text = value; }
        }

        private void foodcategoryButton_MouseClick(object sender, MouseEventArgs e)
        {
            //when the button is clicked - need to get the category id of that name
            String foodCategoryBtnID = txtFCBtnCategoryID.Text;
            //MessageBox.Show(foodCategoryBtnID + " Buttton clicked");

            RestaurantPOS resPos = RestaurantPOS.getInstance();
            resPos.filterFoodCards(foodCategoryBtnID);      
        }
    }

   
}
