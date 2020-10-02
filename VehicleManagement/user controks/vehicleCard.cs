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
    public partial class vehicleCard : UserControl
    {
        public vehicleCard()
        {
            InitializeComponent();
        }

        public String vehicleId
        {
            get { return lblVCardID.Text; }
            set { lblVCardID.Text = value; }

        }
        public String vNumber
        {
            get { return lblVNumber.Text; }
            set { lblVNumber.Text = value; }

        }

        public String vtype
        {
            get { return lblvtype.Text; }
            set { lblvtype.Text = value; }

        }

        public String rentPerDay
        {
            get { return lblRentPerday.Text; }
            set { lblRentPerday.Text = value; }

        }

        public String rentPerKM
        {
            get { return lblRentperKM.Text; }
            set { lblRentperKM.Text = value; }

        }

        public Image vimage
        {
            get { return picBoxvehicle.Image; }
            set { picBoxvehicle.Image = value; }
        }

        private void picBoxvehicle_Click(object sender, EventArgs e)
        {
            AddRentDetails rent = new AddRentDetails();
            rent.setvalues(this.vehicleId, this.vtype, this.vNumber, this.vimage);
            rent.Show();
            this.Hide();
        }
    }
}
