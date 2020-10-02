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
    public partial class AddRentDetails : Form
    {
        
        public AddRentDetails()
        {
            InitializeComponent();
        }

        public void setvalues(String id,String type,String number, Image img)
        {
            textVehiID.Text = id;
            txtVehicleNo.Text = number;
            comboVCategory.Text = type;
            picBoxVehicleImage.Image = img;


        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {

        }
    }
}
