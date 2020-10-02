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
    public partial class AddNewRent : Form
    {
        private static AddNewRent uniqueInstance = null;
        private List<vehicleCard> vehiclecardList = new List<vehicleCard>();
        private List<Vehicle> vehicleList = new List<Vehicle>();
        private vehicleCard Vcard;

        private AddNewRent()
        {
            InitializeComponent();
        }

        public static AddNewRent getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new AddNewRent();
            }
            return uniqueInstance;
        }

        //method to load vehicles 
        //method to load the categories
        public void loadvehicleCards()
        {
            //clear the card list 
            vehiclecardList.Clear();

            using (DBEntities db = new DBEntities())
            {
                vehicleList = db.Vehicles.ToList();

                foreach (Vehicle Item in vehicleList)
                {
                    //creating new card 
                    Vcard = new vehicleCard();

                    Vcard.vNumber = Item.vehicleNo;
                    Vcard.vtype = Item.type;
                    Vcard.rentPerDay = Item.RentPerDay.ToString();
                    Vcard.rentPerKM = Item.RentPerkm.ToString();
                    Vcard.vimage = Util.convertBinaryToImage(Item.VehicleImage);


                    //adding card to the list
                    vehiclecardList.Add(Vcard);

                }

            }


            //adding cards to the flow panel
            foreach (vehicleCard card in vehiclecardList)
            {
                flowRentVehiclePanel.Controls.Add(card);
            }

        }//

        private void AddNewRent_Load(object sender, EventArgs e)
        {
            loadvehicleCards();
        }
    }
}
