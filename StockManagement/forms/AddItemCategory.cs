using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Sarasi_HMS
{
    public partial class AddItemCategory : Form
    {
        private static AddItemCategory uniqueInstance = null;

        private String status = "insert"; //add or update
        private static String itemtype;

        ItemCategory itemCategory = new ItemCategory(); //raw object

        private AddItemCategory()
        {
            InitializeComponent();
        }

        public static AddItemCategory getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new AddItemCategory();
            }
            return uniqueInstance;
        }

        private void btnSave_ItemCategory_Click(object sender, EventArgs e)
        {
            if (validateFormDetails())
            {
                itemCategory.itemCategoryID = txtItemCategoryID.Text;
                itemCategory.categoryName = txtItemCategoryName.Text;
                itemCategory.description = txtItemCategoryDescription.Text;


                using (DBEntities db = new DBEntities())
                {
                    if (status == "insert")
                    {
                        db.ItemCategories.Add(itemCategory);

                        MessageBox.Show("Category Added Successfully");
                    }
                    else if (status == "update")
                    {
                        //updating the database 
                        db.Entry(itemCategory).State = EntityState.Modified;

                        MessageBox.Show("Category Updated Successfully");
                    }

                    db.SaveChanges();
                    clearTexts();
                }

                //addding new Item to the Restaurant POS as a button
                KitchenPOS.getInstance().loadCategoryButtons();

                ///-------clear the flow layout and re load the category list 
                ItemCategories itemcategories = ItemCategories.getInstance();
                itemcategories.clearCatgoryList();
                itemcategories.loadItemCatrgories();
                itemcategories.Show();
                this.Hide();
            }//end of if 
            
        }//end  of save S

        public bool validateFormDetails()
        {
            bool flag = false;
            if (String.IsNullOrEmpty(txtItemCategoryID.Text.Trim()))
            {
                MessageBox.Show("please Generate Category id", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (String.IsNullOrEmpty(txtItemCategoryName.Text.Trim()))
            {
                
                MessageBox.Show("please enter Category name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(Int32.TryParse(txtItemCategoryName.Text,out var res))
                {
                    MessageBox.Show("Category Name cannot be a number","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    flag = true;
                }
               
            }
            return flag;
        }


        //method to edit item category details 
        public void editcategory(String id)
        {
            //retreiving selected row 
            using (DBEntities db = new DBEntities())
            {
                //setting status to update
                status = "update";
                btnSave_ItemCategory.Text = "Update";

                itemCategory = db.ItemCategories.Where(x => x.itemCategoryID == id).FirstOrDefault();
                MessageBox.Show(itemCategory.itemCategoryID);

                //storing values to the textboxes
                txtItemCategoryID.Text = itemCategory.itemCategoryID;
                txtItemCategoryName.Text = itemCategory.categoryName;
                txtItemCategoryDescription.Text = itemCategory.description;


            }
        }//end of edit method 



        public void clearTexts()
        {
            txtItemCategoryDescription.Text = txtItemCategoryID.Text = txtItemCategoryName.Text = "";
        }

        private void btnGenerate_ItemCategoryID_Click(object sender, EventArgs e)
        {
            String keyy = Util.generateKey(itemtype);
            MessageBox.Show("New key generated - " + keyy);
            txtItemCategoryID.Text = keyy;
        }

        private void radioKitchenItem_CheckedChanged(object sender, EventArgs e)
        {
            itemtype = "ItemCategory_KtchenItem";
        }

        private void radioReadyMade_CheckedChanged(object sender, EventArgs e)
        {
            itemtype = "ItemCategory_ReadyMade";
        }

        private void btnCancel_itemCategory_Click(object sender, EventArgs e)
        {
            ItemCategories ic = ItemCategories.getInstance();
            this.Hide();
            ic.Show();
        }
    }
}