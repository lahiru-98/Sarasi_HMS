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
    public partial class BillRow : UserControl
    {
        RestaurantPOS respos = RestaurantPOS.getInstance();
        public BillRow()
        {
            InitializeComponent();
        }

       
        public string FoodName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public String Quantity
        {
            get { return lblQty.Text; }
            set { lblQty.Text = value; }
        }

        public string total
        {
            get { return lblSubTotal.Text; }
            set { lblSubTotal.Text = value; }
        }
        public string billrowID
        {
            get { return lblbillrowId.Text; }
            set { lblbillrowId.Text = value; }
        }

        public string unitPrice
        {
            get { return lblUnitPrice.Text; }
            set { lblUnitPrice.Text = value; }
        }


        private void btnAddition_Click(object sender, EventArgs e)
        {            
            respos.incrementByOne(this.billrowID,this.total);
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            respos.decrementByOne(this.billrowID, this.total);
            respos.reduceAmountToPay(this.unitPrice);
        }
    }
}
