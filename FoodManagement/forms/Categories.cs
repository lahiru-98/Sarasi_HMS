using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasi_HMS
{
    public partial class Categories : Form
    {
        //unique instance 
        private static Categories uniqueInstance=null;

        //category list 
        private List<FoodCategory> foodCategories = new List<FoodCategory>();
        //category-card List
        private List<CategoryCard> categoryCardList = new List<CategoryCard>();
        private CategoryCard categoryCard; //instance variable

        private FoodCategory Fcategory; //to perform delete operation
      

        private Categories()
        {
            InitializeComponent();
            
        }
        public static Categories getInstance()
        {
            
            if (uniqueInstance == null)
            {
                uniqueInstance = new Categories();
            }

            return uniqueInstance;
        }

        private void btnAddnewCategory_Click(object sender, EventArgs e)
        {
            AddFoodCategory addFoodCategories = AddFoodCategory.getInstance();
            addFoodCategories.Show();
            this.Hide();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            loadFoodCategories();
        }

        //method to load the categories
        public void loadFoodCategories()
        {
            //clear the card list 
            categoryCardList.Clear();

            using (DBEntities db = new DBEntities())
            {
                foodCategories = db.FoodCategories.ToList();

                foreach(FoodCategory Item in foodCategories)
                {
                    //creating new card 
                    categoryCard = new CategoryCard();

                    categoryCard.categoryName = Item.name;
                    categoryCard.categorydescription = Item.description;
                    categoryCard.cardId = Item.foodCategoryID;

                    //adding card to the list
                    categoryCardList.Add(categoryCard);
                    
                }

            }

          
            //adding cards to the flow panel
            foreach(CategoryCard card in categoryCardList)
            {
                flowFoodCategoryList.Controls.Add(card);
            }

        }//


        //method to delete a category 
        public void deleteCategory(String id)
        {
            if(MessageBox.Show("Are you sure to Delete this record?","Delete Category", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (DBEntities db = new DBEntities())
                {
                    //getting the object whichh need to be deleted 
                    Fcategory = db.FoodCategories.Where(fc => fc.foodCategoryID == id).First();
                    //delete the object 
                    db.FoodCategories.Remove(Fcategory);
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
            loadFoodCategories();
        }//end of delete category method *******************

        public void clearCatgoryList()
        {
            flowFoodCategoryList.Controls.Clear();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            FoodManagement foodManagement = FoodManagement.getInstance();
            foodManagement.Show();
            this.Hide();
        }


        
    }
}
