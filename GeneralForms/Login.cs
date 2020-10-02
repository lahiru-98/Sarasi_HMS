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
    public partial class Login : Form
    {

        //unique u=instance 
        private static Login uniqueinstance = null;

       

        private String entered_userName, entered_password,logged_loginId;
        private List<UserLogin> user;


        private Login()
        {
            InitializeComponent();

            panelLoginMain.BackColor = Color.FromArgb(160, Color.Black);
        }

        public static Login getInstance()
        {
            if(uniqueinstance == null)
            {
                uniqueinstance = new Login();
            }
            return uniqueinstance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //getting user inputs
            entered_userName = txtUserName.Text;
            entered_password = txtPassword.Text;

            //getting the loginId respective to the credentions
            using(DBEntities db = new DBEntities())
            {
                //getting matching username Object
                 user = db.UserLogins.Where(x => x.username == entered_userName && x.password==entered_password).ToList();
                 int count = user.Count; //counting the noOf Rows

                //validating the Login
                if (count == 1)
                {
                    MessageBox.Show("Login Successs!!!");

                    //extracting the login ID of the user 
                    logged_loginId = user.First().loginID.ToString();

                    //filtering ...
                    if (logged_loginId.StartsWith("M")||logged_loginId.StartsWith("m"))
                    {
                        MessageBox.Show("Welcome Manager !!!");
                        //redirecting to Addmin Panel
                        AdminPanelForm adminPanel = AdminPanelForm.getInstance();
                        adminPanel.Show();
                        this.Hide();
                    }
                    else if (logged_loginId.StartsWith("HF") || logged_loginId.StartsWith("hf"))
                    {
                        MessageBox.Show("Welcome head Chef !!!");
                        KitchenPOS kitchenpos = KitchenPOS.getInstance();
                        kitchenpos.Show();
                        this.Hide();

                    }
                    else if (logged_loginId.StartsWith("R") || logged_loginId.StartsWith("r"))
                    {
                        MessageBox.Show("Welcome Receiptionist");
                        RestaurantPOS restaurantpos = RestaurantPOS.getInstance();
                        restaurantpos.Show();
                        this.Hide();
                    }


                }
                else if(count==0)
                {
                    MessageBox.Show("Invalid Credentials!!!");
                }
                else
                {
                    MessageBox.Show("Error !!!");
                }

              
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
