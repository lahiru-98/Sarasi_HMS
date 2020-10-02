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
    public partial class ReadyMadrProductAlerts : Form
    {

        private static ReadyMadrProductAlerts uniqueInstance = null;

        private DataTable expiredRPTable = new DataTable();
        private List<getExpiredReadyMades_Result> expiredReadyMades = new List<getExpiredReadyMades_Result>();
        private DataTable toBeExpiredReadyMAdesTable = new DataTable();
        private List<getExpiredReadyMadesWithinNextMonth_Result> toBeExpiredReadyMadesList = new List<getExpiredReadyMadesWithinNextMonth_Result>();
        // private List<>

       
        private ReadyMadrProductAlerts()
        {
            InitializeComponent();
            setTableColumns();
        }

        public static ReadyMadrProductAlerts getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ReadyMadrProductAlerts();
            }
            return uniqueInstance;
        }

        //method to set data tables 
        private void setTableColumns()
        {
            expiredRPTable.Columns.Add("Name");
            expiredRPTable.Columns.Add("Category");
            expiredRPTable.Columns.Add("addedOn");
            expiredRPTable.Columns.Add("ExpireDate");

            toBeExpiredReadyMAdesTable.Columns.Add("Name");
            toBeExpiredReadyMAdesTable.Columns.Add("Category");
            toBeExpiredReadyMAdesTable.Columns.Add("addedOn");
            toBeExpiredReadyMAdesTable.Columns.Add("ExpireDate");
        }

        //method to load the expired readymade products 
        public void loadExpiredReadyMades()
        {
            expiredRPTable.Clear();
            gunaRPAlerts.Refresh();

            using (DBEntities db = new DBEntities())
            {
                expiredReadyMades = db.getExpiredReadyMades().ToList();

            }

            foreach (getExpiredReadyMades_Result item in expiredReadyMades)
            {
                expiredRPTable.Rows.Add(item.name, item.categoryName, item.date, item.expireDate);

            }
            gunaRPAlerts.DataSource = expiredRPTable;
        }

        //method to get ready made products will be expired  within next month
        private void loadExpiredRPWithinNextMonth()
        {
            toBeExpiredReadyMAdesTable.Clear();
            gunaRPAlerts.Refresh();

            using (DBEntities db = new DBEntities())
            {
                toBeExpiredReadyMadesList = db.getExpiredReadyMadesWithinNextMonth().ToList();
            }

            foreach (getExpiredReadyMadesWithinNextMonth_Result item in toBeExpiredReadyMadesList)
            {
                toBeExpiredReadyMAdesTable.Rows.Add(item.name, item.categoryName, item.date, item.expireDate);

            }
            gunaRPAlerts.DataSource = toBeExpiredReadyMAdesTable;

        }
        private void btnBackRPAlerts_Click(object sender, EventArgs e)
        {
            FoodManagement fm = FoodManagement.getInstance();
            this.Hide();
            fm.Show();
        }

        private void ReadyMadrProductAlerts_Load(object sender, EventArgs e)
        {
            loadExpiredReadyMades();


        }

        private void btnExpirednext30RP_Click(object sender, EventArgs e)
        {
            loadExpiredRPWithinNextMonth();
        }
    }
}
