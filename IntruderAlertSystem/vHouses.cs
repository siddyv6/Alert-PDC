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
    public partial class vHouses : Form
    {
        private static vHouses vHouse = null;

        public vHouses()
        {
            InitializeComponent();
        }
        public static Form getInstance()
        {
            if (vHouse == null)
            {
                vHouse = new vHouses();
            }

            return vHouse;
        }
    }
}
