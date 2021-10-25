using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookClubPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculatePoints_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtNumberOfBooks.Text);
          
            if(x == 1)
                lblCalculatedPoints.Text = "You earned " + "5" + " points";

            if (x == 2) 
                lblCalculatedPoints.Text = "You earned " + "15" + " points";

            if(x== 3)
                lblCalculatedPoints.Text = "You earned " + "30" + " points";

            if(x >= 4)
                lblCalculatedPoints.Text = "You earned " + "60" + " points";

            else
                lblCalculatedPoints.Text = "You earned " + "no" + " points";
        }
    }
}
