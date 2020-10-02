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
    public partial class POSsettings : Form
    {
        private static POSsettings uniqueInstance = null;
        private POSsettings()
        {
            InitializeComponent();
          //  this.BackColor = Color.FromArgb(160, Color.Black);
            ApplyThemes(Color.Black, Color.Black);
        }

        public static POSsettings getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new POSsettings();
            }
            return uniqueInstance;
        }

        public  void ApplyThemes(Color btnColor, Color panelColor)
        {
            
            foreach (Button Item in RestaurantPOS.ResPOSButtons)
            {
                Item.BackColor = Color.FromArgb(175, btnColor);
               
            }

            foreach (Panel Item in RestaurantPOS.ResPOSPanels)
            {
                Item.BackColor = Color.FromArgb(155, panelColor);
                
            }


        }


        private void posThemeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantPOS resPos = RestaurantPOS.getInstance();
            if (posThemeSelector.Text == "Light")
            {
                ApplyThemes(Color.Black, Color.Black);
                resPos.changeBackImage(0);
            }
            else if (posThemeSelector.Text == "Dark")
            {
                ApplyThemes(zColor(228, 63, 90), zColor(228,63,90));
                resPos.changeBackImage(1);
            }
        }


        Color zColor(int r, int g, int b)
        {   //this method will return rgb Colors
            return Color.FromArgb(r, g, b);
        }

        private void btnposSettingOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestaurantPOS resPos = RestaurantPOS.getInstance();
            resPos.Show();
        }
    }
}
