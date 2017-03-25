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
    public partial class HPage : Form
    {
        private static HPage hPage = null;

        public HPage()
        {
            InitializeComponent();
        }

        public static Form getInstance()
        {
            if (hPage == null)
            {
                hPage = new HPage();
            }

            return hPage;
        }


        private void VHLogs_Click(object sender, EventArgs e)
        {
            HLogs.getInstance().Show();
            //this.Hide();
        }

        private void SLogs_Click(object sender, EventArgs e)
        {
            SLog.getInstance().Show();
            //this.Hide();
        }

        private void viewHouse_Click(object sender, EventArgs e)
        {
            vHouses.getInstance().Show();


        }

        private void createHouse_Click_1(object sender, EventArgs e)
        {
            Home.getInstance().Show();
            this.Hide();

        }
    }
}
