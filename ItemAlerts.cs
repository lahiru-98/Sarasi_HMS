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
    public partial class ItemAlerts : Form
    {
        private static ItemAlerts uniqueInstance = null;
        StockManagement sm = StockManagement.getInstance();

        private DataTable expiredItemTable = new DataTable();
        private DataTable toBeexpiredItemTable = new DataTable();
        private List<getExpiredItems1_Result> expired = new List<getExpiredItems1_Result>();
        private List<getExpiredItemsWithinNextMonth_Result> toBeExpired = new List<getExpiredItemsWithinNextMonth_Result>();

    
        private ItemAlerts()
        {
            InitializeComponent();
            setTableColumns();
        }

        private void setTableColumns()
        {
            expiredItemTable.Columns.Add("Name");
            expiredItemTable.Columns.Add("Category");
            expiredItemTable.Columns.Add("addedOn");
            expiredItemTable.Columns.Add("ExpireDate");


            toBeexpiredItemTable.Columns.Add("Name");
            toBeexpiredItemTable.Columns.Add("Category");
            toBeexpiredItemTable.Columns.Add("addedOn");
            toBeexpiredItemTable.Columns.Add("ExpireDate");

        }


        public static ItemAlerts getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ItemAlerts();
            }
            return uniqueInstance;
        }

        private void btnBackItemAlerts_Click(object sender, EventArgs e)
        {
            sm.Show();
            this.Hide();
        }


        public void loadExpiredItems() {

            expiredItemTable.Clear();
            gunaItemAlerts.Refresh();

            using (DBEntities db = new DBEntities())
            {
                expired = db.getExpiredItems1().ToList();
               
            }

            foreach (getExpiredItems1_Result item in expired)
            {
                expiredItemTable.Rows.Add(item.name, item.categoryName, item.date, item.expireDate);

            }
            gunaItemAlerts.DataSource = expiredItemTable;
        }


        private void loadExpiredWithinNextMonth()
        {
            toBeexpiredItemTable.Clear();
            gunaItemAlerts.Refresh();

            using (DBEntities db = new DBEntities())
            { 
                toBeExpired = db.getExpiredItemsWithinNextMonth().ToList();
            }

            foreach (getExpiredItemsWithinNextMonth_Result item in toBeExpired)
            {
                toBeexpiredItemTable.Rows.Add(item.name, item.categoryName, item.date, item.expireDate);

            }
            gunaItemAlerts.DataSource = toBeexpiredItemTable;

        }

        private void ItemAlerts_Load(object sender, EventArgs e)
        {
            loadExpiredItems();
        }

        public void refreshExpiredItemsTable()
        {
            gunaItemAlerts.Refresh();
        }

        private void btnExpirednext30_Click(object sender, EventArgs e)
        {
            loadExpiredWithinNextMonth();
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            loadExpiredItems();
        }
    }
}
