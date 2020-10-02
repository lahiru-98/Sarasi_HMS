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
    public partial class POSKICard : UserControl
    {
        KitchenPOS kitpos = KitchenPOS.getInstance();
        RestaurantPOS rpos = RestaurantPOS.getInstance();
        public POSKICard()
        {
            InitializeComponent();
        }

        public String KItemName
        {
            get { return lblKitchenItem.Text; }
            set { lblKitchenItem.Text = value; }
        }

        public String KItemPrice
        {
            get { return lblKitchenPrice.Text; }
            set { lblKitchenPrice.Text = value; }
        }

        public Image ItemImage
        {
            get { return picBoxKitchen.Image; }
            set { picBoxKitchen.Image = value; }
        }

        public String KItemCardID
        {
            get { return lblItemCardID.Text; }
            set { lblItemCardID.Text = value; }
        }

        public String MeasurementUnit
        {
            get { return lblMeasurementUnit.Text; }
            set { lblMeasurementUnit.Text = value; }
        }
        private void picBoxKitchen_Click(object sender, EventArgs e)
        {
            if (KItemCardID.StartsWith("I"))
            {
                kitpos.addToStockOutList(this.KItemCardID, this.KItemName, this.KItemPrice, this.MeasurementUnit);
                kitpos.setStockoutAmount();
            }
            else
            {
                rpos.addToBillList(this.KItemCardID, this.KItemName, this.KItemPrice);
                rpos.setAmountToPay();
            }
            
        }
    }
}
