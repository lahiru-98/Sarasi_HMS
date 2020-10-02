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
    public partial class LoadingForm : Form
    {
        
        

        public LoadingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width == 700)
            {
                timer1.Stop();
                // AdminPanelForm adminPanelForm = AdminPanelForm.getInstance();
                //adminPanelForm.Show();

                //RestaurantPOS resPos = RestaurantPOS.getInstance();
                //resPos.Show();

                Login login = Login.getInstance();
                login.Show();
                this.Hide();
            }

        }
    }
}
