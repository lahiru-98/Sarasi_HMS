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
    public partial class FoodProgress : UserControl
    {
        public static Color FoodbackColor;

        public FoodProgress()
        {
            InitializeComponent();
            this.BackColor = FoodbackColor;

            chart1.Titles.Add("Pie Chart");

            chart1.Series["s1"].Points.AddXY("Kottu", 40);
            chart1.Series["s1"].Points.AddXY("soup", 10);
            chart1.Series["s1"].Points.AddXY("Fried Rice", 45);

        }

        public static Color FoodprogressColor
        {
            get { return FoodbackColor; }
            set { FoodbackColor = value; }
        }



     
    }
}
