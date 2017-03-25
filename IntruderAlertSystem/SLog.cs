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
    public partial class SLog : Form
    {

        private static SLog Slogs = null;


        public SLog()
        {
            InitializeComponent();
        }
        public static Form getInstance()
        {
            if (Slogs == null)
            {
                Slogs = new SLog();
            }

            return Slogs;
        }

    }
}
