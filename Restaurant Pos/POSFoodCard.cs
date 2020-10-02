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
    public partial class POSFoodCard : UserControl
    {
        RestaurantPOS respos = RestaurantPOS.getInstance();
        public POSFoodCard()
        {
            InitializeComponent();
        }

        public String foodName
        {
            get { return lblFoodItem.Text; }
            set { lblFoodItem.Text = value; }
        }

        public String foodPrice
        {
            get { return lblFoodPrice.Text; }
            set { lblFoodPrice.Text = value; }
        }

        public Image foodImage
        {
            get { return picBoxFood.Image; }
            set { picBoxFood.Image = value; }
        }

        public String foodCardID
        {
            get { return lblFoodCardID.Text; }
            set { lblFoodCardID.Text = value; }
        }

        private void picBoxFood_Click(object sender, EventArgs e)
        {
            respos.addToBillList(this.foodCardID, this.foodName, this.foodPrice);
            respos.setAmountToPay();

        }
    }
}
