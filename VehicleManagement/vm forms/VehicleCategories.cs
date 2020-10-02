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
    public partial class VehicleCategories : Form
    {
        private static VehicleCategories uniqueInstance = null;
        private List<VehicleCategory> vCategoriesList = new List<VehicleCategory>();
        private List<VehicleCategoryCard> vcCardsList = new List<VehicleCategoryCard>();
        private VehicleCategoryCard vccard;

        private VehicleCategory vehicategory;
        private VehicleCategories()
        {
            InitializeComponent();
        }
        public static VehicleCategories getInstance()
        {
            if(uniqueInstance== null)
            {
                uniqueInstance = new VehicleCategories();
            }
            return uniqueInstance;
        }

        private void btnAddnewCategory_Click(object sender, EventArgs e)
        {
            AddVehicleCategory avc = AddVehicleCategory.getInstance();
            avc.Show();
            this.Hide();
        }

        //method to load the categories
        public void loadFoodCategories()
        {
            //clear the card list 
            vcCardsList.Clear();

            using (DBEntities db = new DBEntities())
            {
                vCategoriesList = db.VehicleCategories.ToList();

                foreach (VehicleCategory Item in vCategoriesList)
                {
                    //creating new card 
                    vccard = new VehicleCategoryCard();

                    vccard.vcName = Item.name;
                    vccard.vcDescription = Item.description;
                    vccard.vcID = Item.vehicleCategoryID;

                    //adding card to the list
                    vcCardsList.Add(vccard);

                }

            }


            //adding cards to the flow panel
            foreach (VehicleCategoryCard card in vcCardsList)
            {
                flowVehicleCategoryList.Controls.Add(card);
            }

        }//

        private void VehicleCategories_Load(object sender, EventArgs e)
        {
            loadFoodCategories();
        }

        public void clearCatgoryList()
        {
            flowVehicleCategoryList.Controls.Clear();
        }

        //method to delete a category 
        public void deleteCategory(String id)
        {
            if (MessageBox.Show("Are you sure to Delete this record?", "Delete Category", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (DBEntities db = new DBEntities())
                {
                    //getting the object whichh need to be deleted 
                    vehicategory = db.VehicleCategories.Where(fc => fc.vehicleCategoryID == id).First();
                    //delete the object 
                    db.VehicleCategories.Remove(vehicategory);
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
    }
}
