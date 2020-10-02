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
    public partial class BillItemRow : UserControl
    {
        KitchenPOS kpos = KitchenPOS.getInstance();
        public BillItemRow()
        {
            InitializeComponent();
        }

        public string ItemName
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

        public string purchasePrice
        {
            get { return lblPurchasePrice.Text; }
            set { lblPurchasePrice.Text = value; }
        }

        public string measurementUnit
        {
            get { return lblmeasurementunit.Text; }
            set { lblmeasurementunit.Text = value; }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            kpos.incrementByOne(this.billrowID, this.total);

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            kpos.decrementByOne(this.billrowID, this.total);
            kpos.reduceStockoutAmount(this.purchasePrice);
        }
    }
}
