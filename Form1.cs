using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasi_HMS
{
    public partial class AdminPanelForm : Form
    {
        //unique instance 
        private static AdminPanelForm uniqueInstance = null;


        //List of Buttons 
        public static List<Button> AdminPanelbuttons = new List<Button>();
        public static List<Panel> AddminPanelPanels = new List<Panel>();

       

        private AdminPanelForm()
        {
            InitializeComponent();
            initializeAdd();
            setDefaultValues(); //setting up the default aspects 

            Settings.ApplyThemes(Color.Black, Color.Black, Settings.zColor(246, 255, 199),Color.White, Color.Chartreuse,Color.White,Color.Yellow);
            //applying light theme initially

        }

        public static AdminPanelForm getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new AdminPanelForm();
            }
            return uniqueInstance;
        }

        private void initializeAdd()
        {
            //adding buttons 
            AdminPanelbuttons.Add(btnAccomodations);
            AdminPanelbuttons.Add(btnCustomerManagement);
            AdminPanelbuttons.Add(btnEmployeeManagement);
            AdminPanelbuttons.Add(btnEventManagement);
            AdminPanelbuttons.Add(btnFoodManagement);
            AdminPanelbuttons.Add(btnSupplierManagement);
            AdminPanelbuttons.Add(btnKitchenAndStock);
            AdminPanelbuttons.Add(btnVehiclerentings);
            AdminPanelbuttons.Add(btnSettings);
            AdminPanelbuttons.Add(btnEventManagement);

            //adding to the settings List
            Settings.AllButtons.AddRange(AdminPanelbuttons);

            
            //Adding Panels 
            AddminPanelPanels.Add(panelMain);
            AddminPanelPanels.Add(panelBottom);

            //adding Panels to the All Panel list
            Settings.AllPanels.AddRange(AddminPanelPanels);

        }
        //method to change background image ********************************************
        public  void changeBackImage(int themenumber)
        {
            if (themenumber == 0)
            {
                this.BackgroundImage = Properties.Resources.Light;
            }
            else if (themenumber == 1)
            {
                this.BackgroundImage = Properties.Resources.ios_13_grey_dark_background;
            }
        }

        private void setDefaultValues()
        {
            DateTime time = DateTime.Now.ToLocalTime();
            lblDateTime.Text = time.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFoodManagement_Click(object sender, EventArgs e)
        {
            FoodManagement fm = FoodManagement.getInstance();
            this.Hide();
            fm.Show();
        }

    

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
           
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = Settings.getInstance();
            this.Hide();
            settings.Show();

        }

        private void btnEventManagement_Click(object sender, EventArgs e)
        {
           
        }

        private void btnKitchenAndStock_Click(object sender, EventArgs e)
        {
            StockManagement sm = StockManagement.getInstance();
            this.Hide();
            sm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = Login.getInstance();
            login.Show();
        }

        private void btnVehiclerentings_Click(object sender, EventArgs e)
        {
            VehicleManagementNew vm = new VehicleManagementNew();
            vm.Show();
            this.Hide();
        }
    }
}
