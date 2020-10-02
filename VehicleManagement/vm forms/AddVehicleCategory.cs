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
    public partial class AddVehicleCategory : Form
    {
        private static AddVehicleCategory uniqueInstance = null;
        VehicleCategory vCategory = new VehicleCategory();
        String status = "insert";

        private AddVehicleCategory()
        {
            InitializeComponent();
        }
        public static AddVehicleCategory getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new AddVehicleCategory();
            }
            return uniqueInstance;
        } 

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = Util.generateKey("vehicleCategory");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            vCategory.vehicleCategoryID = txtCategoryID.Text;
            vCategory.description = txtCategoryDescription.Text;
            vCategory.name = txtCategoryName.Text;

            using (DBEntities db = new DBEntities())
            {
                if (status == "insert")
                {
                    db.VehicleCategories.Add(vCategory);
                    MessageBox.Show("Vehicle category added successfully");
                }
                else if (status == "update")
                {
                    db.Entry(vCategory).State = EntityState.Modified;

                    MessageBox.Show("Vehicle Category Updated Successfully");
                }
              
                db.SaveChanges();
         
            }

            ///-------clear the flow layout and re load the category list 
            VehicleCategories Vcategories = VehicleCategories.getInstance();
            Vcategories.clearCatgoryList();
            Vcategories.loadFoodCategories();
            Vcategories.Show();
            this.Hide();
        }//**************************

        //method to edit category details 
        public void editcategory(String id)
        {
            //retreiving selected row 
            using (DBEntities db = new DBEntities())
            {
                //setting status to update
                status = "update";
                btnSave.Text = "Update";

                vCategory = db.VehicleCategories.Where(x => x.vehicleCategoryID == id).FirstOrDefault();
                MessageBox.Show(vCategory.vehicleCategoryID);

                //storing values to the textboxes
                txtCategoryID.Text = vCategory.vehicleCategoryID;
                txtCategoryName.Text = vCategory.name;
                txtCategoryDescription.Text = vCategory.description;


            }
        }//end of edit item category method

    }
}
