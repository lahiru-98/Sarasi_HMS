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
    public partial class AddnewVehicle : Form
    {
        private static AddnewVehicle uniqueInstance = null;
        Vehicle vehimodel = new Vehicle();
         String fileName;
        private AddnewVehicle()
        {
            InitializeComponent();
        }

        public static AddnewVehicle getInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new AddnewVehicle();
            }
            return uniqueInstance;
        }


        private void btnProductIDGenerate_Click(object sender, EventArgs e)
        {
            txtVID.Text = Util.generateKey("vehicle");
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            vehimodel.vehicleID = txtVID.Text;
            vehimodel.vehicleNo = txtVno.Text;
            vehimodel.type = comboVCategory.Text;
            vehimodel.model = txtModel.Text;
            vehimodel.brand = txtbrand.Text;
            vehimodel.InsuaranceType = txtVInsuarancetype.Text;


            double rentPerday;
            bool result1 = Double.TryParse(txtRentPerday.Text, out rentPerday);
            if (result1 == false)
            {
                MessageBox.Show("Please enter Rent per day");
            }
            else
            {
                vehimodel.RentPerDay = (float)rentPerday;
            }

            double rentPerKM;
            bool result2 = Double.TryParse(txtrentPerKM.Text, out rentPerKM);
            if (result1 == false)
            {
                MessageBox.Show("Please enter Rent per KM");
            }
            else
            {
                vehimodel.RentPerkm = (float)rentPerKM;
            }

            vehimodel.VehicleImage = Util.convertImageToBinary(picBoxVehicleImage.Image);

            using(DBEntities db = new DBEntities())
            {
                db.Vehicles.Add(vehimodel);
                db.SaveChanges();
                MessageBox.Show("Vehicle Added Successfully");

            }

        }

        private void btnbrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    picBoxVehicleImage.Image = Image.FromFile(fileName);
                }
            }
        }
    }
}
