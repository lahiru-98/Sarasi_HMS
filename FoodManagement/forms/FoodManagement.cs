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
    public partial class FoodManagement : Form
    {

        //unique instance 
        private static FoodManagement uniqueInstance = null;

        //Lists of Controls 
        public static  List<Panel> FoodmanagementPanels = new List<Panel>();
        public static List<Button> FoodManagementButtons = new List<Button>();

        //Food items List 
        public List<Food> foodItemsList = new List<Food>();
        //foodItem Card list
        public List<FoodItemCard> foodCardsList = new List<FoodItemCard>();
        public FoodItemCard foodcard; //instance variable

        private Food food; //to perform delete operation

        private ReadyMadrProductAlerts rpAltert = ReadyMadrProductAlerts.getInstance();

        private FoodManagement()
        {
            InitializeComponent();
            initializeAdd();
            setDefaultValues();
            // flowPanelFoodList.BackColor = Color.FromArgb(150, Color.Black);

            Settings.ApplyThemes(Color.Black, Color.Black, Settings.zColor(246, 255, 199),Color.White, Color.Chartreuse,Color.White,Color.Yellow);
            //applying light theme initially

            loadFoodItemCards();

        }

        private void setDefaultValues()
        {
            DateTime time = DateTime.Now.ToLocalTime();
            lblDateTime.Text = time.ToString();
        }

        public static FoodManagement getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new FoodManagement();
            }
            return uniqueInstance;
        }


        private void initializeAdd()
        {
            //adding pannels 
            FoodmanagementPanels.Add(panelBottom2);
            FoodmanagementPanels.Add(panelMain2);
            

            //Adding to the All list 
            Settings.AllPanels.AddRange(FoodmanagementPanels);

            //adding Buttons
            FoodManagementButtons.Add(btnAddNewFoods2);
            FoodManagementButtons.Add(btnFoodProgress2);
            FoodManagementButtons.Add(btnFoodAlerts2);
            FoodManagementButtons.Add(btnBack2);
            FoodManagementButtons.Add(btnFoodList);

            Settings.AllButtons.AddRange(FoodManagementButtons);
        }

        public void changeBackImage(int themenumber)
        {
            if (themenumber == 0)
            {
                this.BackgroundImage = Properties.Resources.penicilYellow;
            }
            else if (themenumber == 1)
            {
                this.BackgroundImage = Properties.Resources.DarkThemee;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
           
            AdminPanelForm adminPanel = AdminPanelForm.getInstance();
            adminPanel.Show();
            this.Hide();
        }

        private void FoodManagement_Load(object sender, EventArgs e)
        {
            
           flowPanelFoodList.Show();
           flowPanelFoodList.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
        private void btnFoodAlerts2_Click(object sender, EventArgs e)
        {
             flowPanelFoodList.Hide();
             this.Hide();
             rpAltert.Show();

        }

        private void btnFoodProgress2_Click(object sender, EventArgs e)
        {
           flowPanelFoodList.Hide();
           

        }

      
        private void btnFoodList_Click(object sender, EventArgs e)
        {
           
             flowPanelFoodList.Show();
             flowPanelFoodList.BringToFront();
        }

        private void btnAddNewFoods2_Click(object sender, EventArgs e)
        {
            AddNewFood addFood = AddNewFood.getInstance();
            this.Hide();
            addFood.Show();

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Categories categories = Categories.getInstance();
            categories.Show();
            this.Hide();
        }

        //method to load food item cards to the panel
        public void loadFoodItemCards()
        {
            //clear the card list 
            foodCardsList.Clear();


            using (DBEntities db = new DBEntities())
            {
                foodItemsList = db.Foods.ToList();

                foreach (Food Item in foodItemsList)
                {
                    //creating new card 
                    foodcard = new FoodItemCard();

                    foodcard.cardId = Item.foodCode;
                    foodcard.FoodName = Item.name;
                    foodcard.price = Item.sellingPrice.ToString();
                    foodcard.FoodImage = Util.convertBinaryToImage(Item.foodImage);
                    //adding card to the list
                    foodCardsList.Add(foodcard);

                }

                //adding cards to the flow panel
                foreach (FoodItemCard card in foodCardsList)
                {
                    flowPanelFoodList.Controls.Add(card);
                }

            }
        }//end of load food cards method 

        //method to clear the food flow panel
        public void clearFoodcardpanel()
        {
            flowPanelFoodList.Controls.Clear();
        }


        //method to delete a Food card  
        public void deleteFood(String id)
        {
            if (MessageBox.Show("Are you sure to Delete this record?", "Delete Food", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (DBEntities db = new DBEntities())
                {
                    //getting the object whichh need to be deleted 
                    food = db.Foods.Where(fc => fc.foodCode == id).First();
                    //delete the object 
                    db.Foods.Remove(food);
                    db.SaveChanges();

                }
                MessageBox.Show("Food Removed Successfully!!!");

            }

            //refreshing......
            clearFoodcardpanel();
            loadFoodItemCards();
        }//end of delete Food method *******************

    }
}
