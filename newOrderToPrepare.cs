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
    public partial class newOrderToPrepare : UserControl
    {
        public newOrderToPrepare()
        {
            InitializeComponent();
        }

        public String orderContent
        {
            get { return lblorderContent.Text; }
            set { lblorderContent.Text = value; }
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            
        }

        private void lblorderContent_Click(object sender, EventArgs e)
        {

        }
    }
}
