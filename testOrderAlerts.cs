using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasi_HMS
{
    public partial class testOrderAlerts : UserControl
    {
        public testOrderAlerts()
        {
            InitializeComponent();
        }

        public Image orderpic
        {
            get { return pictureBoxOrder.Image; }
            set { pictureBoxOrder.Image = value; }
        }

        public String OrderList
        {
            get { return lblItems.Text; }
            set { lblItems.Text = value; }
        }
    }
}
