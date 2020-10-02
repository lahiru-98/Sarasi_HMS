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
    public partial class ItemCategoryButton : UserControl
    {
        public ItemCategoryButton()
        {
            InitializeComponent();
        }

        public String ItemButtonName
        {
            get { return txtCategoryButtonName.Text; }
            set { txtCategoryButtonName.Text = value; }
        }

        public String ItemButtonID
        {
            get { return txtICBtnCategoryID.Text; }
            set { txtICBtnCategoryID.Text = value; }
        }

        private void ItemCategoryButton_Click(object sender, EventArgs e)
        {
            String foodCategoryBtnID = txtICBtnCategoryID.Text;
            KitchenPOS kpos = KitchenPOS.getInstance();
            RestaurantPOS rpos = RestaurantPOS.getInstance();

            if (ItemButtonID.StartsWith("KIc")){
                kpos.filterFoodCards(foodCategoryBtnID);
            }else if (ItemButtonID.StartsWith("RPc"))
            {
                rpos.filterFoodCards(foodCategoryBtnID);
            }
            
        }
    }
}
