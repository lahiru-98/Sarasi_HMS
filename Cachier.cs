using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Sarasi_HMS
{
    public partial class Cachier : Form
    {
        private static Cachier uniqueinstance = null;

        private  double totalAmount;
        private string typedPaidAmount = "";
        private String orderNumber;

        private List<getOrderedItems_Result> orderedFoodItems = new List<getOrderedItems_Result>();

        private StockManagement sm = StockManagement.getInstance();

        private Cachier()  
        {
            InitializeComponent();
        }

        public static Cachier getInstance() 
        {
            if (uniqueinstance == null)
            {
                uniqueinstance = new Cachier();
            }
           
            return uniqueinstance;
        }

        private void btnBackToPos_Click(object sender, EventArgs e)
        {
            RestaurantPOS respos = RestaurantPOS.getInstance();
            respos.Show();
            this.Hide();
        }

        public void setTotalFromPos(double tot,String orderID)
        {
            this.totalAmount = tot;
            this.orderNumber = orderID;
        }

        public void updateInitialValues()
        {
            lblTotal.Text = totalAmount.ToString();
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd"); 
            lblTime.Text = DateTime.Now.TimeOfDay.ToString();
        }


        public void updatePaideAmount(String Clickednumber)
        {
            typedPaidAmount = typedPaidAmount + Clickednumber;
            lblTypePaidAmount.Text = typedPaidAmount;
            calculateChange();
            moveLabelLeft();

        }


        public void calculateChange()
        {
            lblPaid.Text = typedPaidAmount;
            double change = double.Parse(typedPaidAmount) - totalAmount;
            lblChange.Text = change.ToString();

        }


        public void moveLabelLeft()
        {
            lblTypePaidAmount.Location = new Point(lblTypePaidAmount.Location.X - 15, lblTypePaidAmount.Location.Y);

            if (lblTypePaidAmount.Location.X > this.Width)
            {
                lblTypePaidAmount.Location = new Point(0 - lblTypePaidAmount.Width, lblTypePaidAmount.Location.Y);
            }
        }


        public void moveLabelRight()
        {
            lblTypePaidAmount.Location = new Point(lblTypePaidAmount.Location.X + 15, lblTypePaidAmount.Location.Y);

            if (lblTypePaidAmount.Location.X > this.Width)
            {
                lblTypePaidAmount.Location = new Point(0 + lblTypePaidAmount.Width, lblTypePaidAmount.Location.Y);
            }
        }

        private void Cachier_Load(object sender, EventArgs e)
        {
            lblTypePaidAmount.Text= typedPaidAmount;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            updatePaideAmount("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            updatePaideAmount("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            updatePaideAmount("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            updatePaideAmount("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            updatePaideAmount("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            updatePaideAmount("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            updatePaideAmount("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            updatePaideAmount("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            updatePaideAmount("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            updatePaideAmount("0");
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            performBackspace();
            moveLabelRight();

        }


        public void performBackspace()
        {
            if ((String.Compare(typedPaidAmount, " ") < 0))
            {
                typedPaidAmount = typedPaidAmount.Substring(0, typedPaidAmount.Length - 1 + 1);
            }
            else
            {
                typedPaidAmount = typedPaidAmount.Substring(0, typedPaidAmount.Length - 1);
            }

            lblTypePaidAmount.Text = typedPaidAmount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //show notification about the new Order
            using(DBEntities db = new DBEntities())
            {
                orderedFoodItems = db.getOrderedItems(orderNumber).ToList();
            }

            //setting up the notification
            showNotification();
            sm.addNewOrders(orderedFoodItems);
        }


        private void showNotification()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.info;
            popup.TitleText = "New Order !!!";
            popup.TitleColor = Color.Blue;
            popup.ContentColor = Color.Brown;

            popup.ContentText = getOrderListString();

            popup.TitleFont = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            popup.ContentFont = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            popup.Popup();
        }

        private String getOrderListString()
        {
            String orderlistString = "Order contains \n";

            foreach(getOrderedItems_Result item in orderedFoodItems)
            {
                String row = "| " + item.name + " - " + item.quantity + "\n";
                orderlistString = orderlistString + row;
            }

            return orderlistString;
        }
    }
}
