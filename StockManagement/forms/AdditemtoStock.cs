using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasi_HMS
{
    public partial class AdditemtoStock : Form
    {
        private static AdditemtoStock uniqueInstance = null;

        Item stockItem = new Item();
        StockAudit stockrow = new StockAudit();
        private AdditemtoStock()
        {
            InitializeComponent();
        }

        public static AdditemtoStock getInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new AdditemtoStock();
            }
            return uniqueInstance;
        }

        //method to set values 
        public void setValues(String id)
        {
            using(DBEntities db = new DBEntities())
            {
                stockItem = db.Items.Where(x => x.itemID == id).FirstOrDefault();

                //generate and assign a key 
                lblAuditNumber.Text = Util.generateKey("stock");
                lblItemName.Text = stockItem.name;
                lblitemID.Text = stockItem.itemID;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddtoStock_Click(object sender, EventArgs e)
        {
            stockrow.stockAuditID = lblAuditNumber.Text;
            stockrow.itemID = lblitemID.Text;

            stockrow.date = DateTime.Today;
            stockrow.time = DateTime.Now.TimeOfDay;

            stockrow.quantity = Int32.Parse(txtQuantity.Text);
            stockrow.inOut = true;
            stockrow.expireDate = expDatePicker.Value;

            using(DBEntities db = new DBEntities())
            {
                db.StockAudits.Add(stockrow);
                db.SaveChanges();
                MessageBox.Show("Item Added to the Stock");
            }


            clearFields();
            this.Hide();
        }

        private void clearFields()
        {
            txtQuantity.Text = "";
        }
    }
}
