using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasi_HMS
{
    public partial class ItemCategories : Form
    {

        private static ItemCategories uniqueInstance = null;

        //category list 
        private List<ItemCategory> itemCategoriesList = new List<ItemCategory>();
        //category-card List
        private List<userControls.ItemCategoryCard> categoryCardList = new List<userControls.ItemCategoryCard>();
        private userControls.ItemCategoryCard itemCategoryCard; //instance variable

        private ItemCategory Icategory; //to perform delete operation

        private ItemCategories()
        {
            InitializeComponent();
        }

        public static ItemCategories getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ItemCategories();
            }
            return uniqueInstance;
        }

        //--------------------------------------------------------------------------------------------------------
        public void loadItemCatrgories()
        {
            //clear the current card list
            categoryCardList.Clear();

            //getting all the item category details in to a list (read) 
            using(DBEntities db = new DBEntities())
            {
                itemCategoriesList = db.ItemCategories.ToList();


                foreach (ItemCategory Item in itemCategoriesList)
                {
                    //creating new card 
                    itemCategoryCard = new userControls.ItemCategoryCard();

                    itemCategoryCard.categoryName = Item.categoryName;
                    itemCategoryCard.categorydescription = Item.description;
                    itemCategoryCard.cardId = Item.itemCategoryID;

                    //adding card to the list
                    categoryCardList.Add(itemCategoryCard);

                }

            }

            //adding cards to the flow panel
            foreach (userControls.ItemCategoryCard card in categoryCardList)
            {
                flowItemCategoryList.Controls.Add(card);
            }

        } //end of loadCategories Method  ---------------------------------------------


        //method to delete Item category 
        public void deleteCategory(String id)
        {
            if (MessageBox.Show("Are you sure to Delete this record?", "Delete Category", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (DBEntities db = new DBEntities())
                {
                    //getting the object whichh need to be deleted 
                    Icategory = db.ItemCategories.Where(fc => fc.itemCategoryID == id).First();
                    //delete the object 
                    db.ItemCategories.Remove(Icategory);

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var entityValidationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in entityValidationErrors.ValidationErrors)
                            {
                                MessageBox.Show("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                            }
                        }
                    }

                }
                MessageBox.Show("Category Removed Successfully!!!");

            }

            //refreshing......
            clearCatgoryList();
            loadItemCatrgories();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            StockManagement sm = StockManagement.getInstance();
            this.Hide();
            sm.Show();
        }

        private void btnAddnewItemCategory_Click(object sender, EventArgs e)
        {
            AddItemCategory addIC = AddItemCategory.getInstance();
            this.Hide();
            addIC.Show();
        }

        
        private void ItemCategories_Load(object sender, EventArgs e)
        {
            //foarm load event
            loadItemCatrgories();
        }


        //method to clear Item Category List 
        public void clearCatgoryList()
        {
            flowItemCategoryList.Controls.Clear();
        }
    }
}
