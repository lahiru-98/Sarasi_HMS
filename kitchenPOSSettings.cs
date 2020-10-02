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
   
    public partial class kitchenPOSSettings : Form
    {
        //unique instance 
        private static kitchenPOSSettings uniqueInstance = null;
        private kitchenPOSSettings()
        {
            InitializeComponent();
        }

        public static kitchenPOSSettings getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new kitchenPOSSettings();
            }
            return uniqueInstance;
        }

        public void ApplyThemes(Color btnColor, Color panelColor)
        {

           
            foreach (Panel Item in KitchenPOS.KitchenPOSPanels)
            {
                Item.BackColor = Color.FromArgb(155, panelColor);

            }


        }


        private void KitchenposThemeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            KitchenPOS kitchenPOS = KitchenPOS.getInstance();
            if (KitchenposThemeSelector.Text == "Light")
            {
                ApplyThemes(Color.Black, Color.Black);
                kitchenPOS.changeBackImage(0);
            }
            else if (KitchenposThemeSelector.Text == "Dark")
            {
                ApplyThemes(zColor(228, 63, 90), zColor(228, 63, 90));
                kitchenPOS.changeBackImage(1);
            }
        }


        Color zColor(int r, int g, int b)
        {   //this method will return rgb Colors
            return Color.FromArgb(r, g, b);
        }

        private void btnKitchenposSettingOK_Click(object sender, EventArgs e)
        {
            KitchenPOS kitchenPOS = KitchenPOS.getInstance();
            this.Hide();
            kitchenPOS.Show();
            kitchenPOS.BringToFront();
        }
    }
}
