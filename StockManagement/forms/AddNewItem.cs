using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasi_HMS
{
    public partial class AddNewItem : Form
    {
        private static AddNewItem uniqueInstance = null;

        Item itemRow = new Item();
        String fileName;
        String operation = "insert";

        private AddNewItem()
        {
            InitializeComponent();
        }

        public static AddNewItem getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new AddNewItem();
            }
            return uniqueInstance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            itemRow.itemID = txtItemID.Text;
            itemRow.name = txtItemName.Text;
            itemRow.limitQuantity = Int32.Parse(txtLimit.Text);
            itemRow.unitOfMeasurement = txtUnitOfMesasure.Text; //#########


            double purchasePrice;
            bool res1 = Double.TryParse(txtPurchacePrice.Text, out purchasePrice);
            if (res1 == false)
            {
                MessageBox.Show("please Fill the purchase price");
            }
            else
            {
                itemRow.purchase_price = (float)purchasePrice;
            }

            itemRow.suppliedBy = "ss";

            itemRow.unitOfMeasurement = txtUnitOfMesasure.Text;
            //setting category id 
            String cid = Util.getCategoryID("ItemCategory", comboItemcategories.Text);
            MessageBox.Show(cid);
            itemRow.categoryID = cid;

            itemRow.image = Util.convertImageToBinary(picBocitempic.Image);

            using (DBEntities db = new DBEntities())
            {

                if (operation == "insert")
                {
                    db.Items.Add(itemRow);
                    MessageBox.Show("Item Added Successfully");
                   
                }
                else if(operation=="update")
                {
                    db.Entry(itemRow).State = EntityState.Modified;
                    MessageBox.Show("Item details Updated Successfully");
                }

                db.SaveChanges();
            }

            StockManagement sm = StockManagement.getInstance();
            sm.clearItemList();
            sm.loadKitchenItems();
            this.Hide();
            sm.Show();

        }//end of save method 

        private void setCategoryComboBox()
        { 
            comboItemcategories.DataSource = getItemCategoryList();
            comboItemcategories.DisplayMember = "categoryName";
        }

        //method to get food category list 
        private List<ItemCategory> getItemCategoryList()
        {   //creating new List 
            List<ItemCategory> Iclist = new List<ItemCategory>();

            using (DBEntities db = new DBEntities())
            {
                Iclist = db.ItemCategories.ToList();

            }
            return Iclist;
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            setCategoryComboBox();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    picBocitempic.Image = Image.FromFile(fileName);
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtItemID.Text = Util.generateKey("item");
        }

        //method to edit food details
        public void editcategory(String id)
        {
            //retreiving selected row 
            using (DBEntities db = new DBEntities())
            {
                //setting operation to update
                operation = "update";
                btnSave.Text = "Update";

                itemRow = db.Items.Where(x => x.itemID == id).FirstOrDefault();
               

                //storing values to the textboxes
                txtItemID.Text = itemRow.itemID;
                txtItemName.Text = itemRow.name;
                txtLimit.Text = itemRow.limitQuantity.ToString();
                txtPurchacePrice.Text = itemRow.purchase_price.ToString();
                comBoSupplier.Text = itemRow.suppliedBy;
                picBocitempic.Image = Util.convertBinaryToImage(itemRow.image);
               
            }
        }//end of edit Food details method

        private void btnBack_Click(object sender, EventArgs e)
        {
            StockManagement sm = StockManagement.getInstance();
            this.Hide();
            sm.Show();
        }
    }
}
