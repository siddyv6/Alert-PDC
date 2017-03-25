using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Home : Form
    {
        private static Home home = null;
        private DataGridView test;

        public Home()
        {
            InitializeComponent();
        }

        public static Form getInstance()
        {
            if (home == null)
            {
                home = new Home();
            }

            return home;
        }

        private void crtFloor_Click(object sender, EventArgs e)
        {

            test = CStuff.creatDG(Convert.ToInt32(X.Text), Convert.ToInt32(Y.Text));
          
             Y.Visible = false;
             X.Visible = false;
             crtFloor.Visible = false;
             label1.Visible = false;
             label2.Visible = false;

            // // set start location to top-left corner
            const int START_LOCATION = 25;

            // // add table to form
            getInstance().Controls.Add(test);

            // set the form size to be the table with some padding
           int padding = START_LOCATION * 2;
           getInstance().ClientSize = new Size(test.Height + padding, test.Width + padding);
        }
    }
}
