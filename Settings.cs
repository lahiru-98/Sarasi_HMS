using Bunifu.Framework.UI;
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
    public partial class Settings : Form
    {
        //unique instance 
        private static Settings uniqueInstance = null;
        private int currentTheme; //save the currently applied Theme

        //Lists  of Controls 
        public static List<Button> AllButtons = new List<Button>();
        public static List<Panel> AllPanels = new List<Panel>();
        public static List<BunifuGradientPanel> AllBuniPanels = new List<BunifuGradientPanel>();
        public static List<TextBox> AllTextBoxes = new List<TextBox>();
      


        AdminPanelForm apf = AdminPanelForm.getInstance();
        FoodManagement fm = FoodManagement.getInstance();

        private Settings()
        {
            InitializeComponent();
            themeSelector.SelectedIndex = currentTheme;
        }

        public static Settings getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Settings();
            }
            return uniqueInstance;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            themeSelector.SelectedIndex = currentTheme;
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            apf.Show();
        }


        //--------------------------------
        public static void ApplyThemes(Color btnColor,Color panelColor,Color txtBoxColor,Color Bleft,Color bRight,Color tLeft,Color tRight)
        {
            foreach(Button Item in AllButtons)
            {
                Item.BackColor = Color.FromArgb(175,btnColor);
            }

            foreach(Panel Item in AllPanels)
            {
                Item.BackColor = Color.FromArgb(155, panelColor);
            }

            foreach (TextBox Item in AllTextBoxes)
            {
                Item.BackColor = txtBoxColor;
            }

            foreach (BunifuGradientPanel Item in AllBuniPanels)
            {
                Item.GradientBottomLeft = Bleft;
                Item.GradientBottomRight = bRight;
                Item.GradientTopLeft = tLeft;
                Item.GradientTopRight = tRight;
            }
            foreach(Panel Item in AddNewFood.AddFoodPanels)
            {
                Item.BackColor = txtBoxColor;
            }
            foreach(ComboBox Item in AddNewFood.AddFoodCombos)
            {
                Item.BackColor = txtBoxColor;
            }
            foreach (PictureBox Item in AddNewFood.AddFoodPicBoxes)
            {
                Item.BackColor = txtBoxColor;
            }






        }

        public static Color zColor(int r, int g, int b)
        {   //this method will return rgb Colors
            return Color.FromArgb(r, g, b);
        }

        private void themeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (themeSelector.Text == "Light")
            {
                ApplyThemes(Color.Black,Color.Black,zColor(246, 255, 199),Color.White, Color.Chartreuse,Color.White,Color.Yellow);
                currentTheme = 0;
                apf.changeBackImage(0);
                fm.changeBackImage(0);

                FoodProgress.FoodprogressColor = Color.FromArgb(160, Color.Black);


               


            }
            else if (themeSelector.Text == "Dark")
            {
                 ApplyThemes(Color.RosyBrown, Color.RosyBrown,zColor(223, 209, 202),Color.White,Color.Black,Color.White,zColor(192, 64, 0));
                currentTheme = 1;
                apf.changeBackImage(1);
                fm.changeBackImage(1);

                FoodProgress.FoodprogressColor = Color.FromArgb(160, Color.RosyBrown);

            }
        }
    }
}
