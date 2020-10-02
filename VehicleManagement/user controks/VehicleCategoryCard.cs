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
    public partial class VehicleCategoryCard : UserControl
    {
        public VehicleCategoryCard()
        {
            InitializeComponent();
        }

        public String vcName
        {
            get { return lblVcName.Text; }
            set { lblVcName.Text = value; }
        }
        public String vcDescription
        {
            get { return lblVCdescription.Text; }
            set { lblVCdescription.Text = value; }
        }

        public String vcID
        {
            get { return txtCardID.Text; }
            set { txtCardID.Text = value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //getting the card id 
            String cardId = this.txtCardID.Text;
            AddVehicleCategory avC = AddVehicleCategory.getInstance();
            avC.editcategory(cardId);
            avC.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String cardID = this.txtCardID.Text; //getting the cliked card id 

            VehicleCategories Vcategories = VehicleCategories.getInstance();
            Vcategories.deleteCategory(cardID); //passing the Id
        }
    }
}
