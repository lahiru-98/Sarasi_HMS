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
    public partial class KitchenitemCard : UserControl
    {
        public KitchenitemCard()
        {
            InitializeComponent();
        }

        public Image itemImage
        {
            get { return picBoxKitchenitem.Image; }
            set { picBoxKitchenitem.Image = value; }
        }

        public String itemName
        {
            get { return lblKitchenitemname.Text; }
            set { lblKitchenitemname.Text = value; }
        }

        public String purchacedPrice
        {
            get { return lblKitchenpurchaseprice.Text; }
            set { lblKitchenpurchaseprice.Text = value; }
        }

        public String itemID
        {
            get { return lblItemId.Text; }
            set { lblItemId.Text = value; }
        }

        private void btnEditItemCard_Click(object sender, EventArgs e)
        {
            //getting the card id 
            String cardId = this.itemID;
            AddNewItem addNwItem = AddNewItem.getInstance();
            addNwItem.editcategory(cardId);
            addNwItem.Show();
            this.Hide();
        }

        private void btndeleteItemCard_Click(object sender, EventArgs e)
        {
            String cardID = this.itemID; //getting the cliked card id 

            StockManagement stockmanagement = StockManagement.getInstance();
            stockmanagement.deleteFood(cardID); //passing the Id 
        }

      

        private void picBoxKitchenitem_Click(object sender, EventArgs e)
        {
            AdditemtoStock ats = AdditemtoStock.getInstance();
            String id = this.itemID;
            ats.setValues(id);
            ats.Show();  
                   
        }
    }
}
