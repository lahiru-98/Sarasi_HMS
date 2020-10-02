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
    public partial class testFoodCard : UserControl
    {
        public testFoodCard()
        {
            InitializeComponent();
        }


        public Image FoodImage
        {
            get { return picBoxFood.Image; }
            set { picBoxFood.Image = value; }
        }

        public String FoodName
        {
            get { return labelFoodName.Text; }
            set { labelFoodName.Text = value; }
        }

        public String FoodPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
    }
}
