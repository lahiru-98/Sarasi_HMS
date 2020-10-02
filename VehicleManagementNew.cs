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
    public partial class VehicleManagementNew : Form
    {

        private List<Vehicle> vehicles = new List<Vehicle>();
        private List<vehicleCard> vehicleCardList = new List<vehicleCard>();
        private vehicleCard Vcard;
        public VehicleManagementNew()
        {
            InitializeComponent();
        }

        //method to load the categories
        public void loadvehicleCards()
        {
            //clear the card list 
            vehicleCardList.Clear();

            using (DBEntities db = new DBEntities())
            {
                vehicles = db.Vehicles.ToList();

                foreach (Vehicle Item in vehicles)
                {
                    //creating new card 
                    Vcard = new vehicleCard();

                    Vcard.vNumber = Item.vehicleNo;
                    Vcard.vtype = Item.type;
                    Vcard.rentPerDay = Item.RentPerDay.ToString();
                    Vcard.rentPerKM = Item.RentPerkm.ToString();
                    Vcard.vimage = Util.convertBinaryToImage(Item.VehicleImage);


                    //adding card to the list
                    vehicleCardList.Add(Vcard);

                }

            }


            //adding cards to the flow panel
            foreach (vehicleCard card in vehicleCardList)
            {
                flowVehiclepanel.Controls.Add(card);
            }

        }//

        private void btnVehiclecategories_Click(object sender, EventArgs e)
        {
            VehicleCategories av = VehicleCategories.getInstance();
            av.Show();
            this.Hide();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddnewVehicle av = AddnewVehicle.getInstance();
            av.Show();
            this.Hide();
        }

        private void VehicleManagementNew_Load(object sender, EventArgs e)
        {
            loadvehicleCards();
        }

        private void btnBackStock_Click(object sender, EventArgs e)
        {
            VehicleManagement.vm_forms.VehiclePOS vpos = new VehicleManagement.vm_forms.VehiclePOS();
            vpos.Show();
            this.Hide();
        }
    }
}
