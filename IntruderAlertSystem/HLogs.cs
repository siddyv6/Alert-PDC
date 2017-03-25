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
    public partial class HLogs : Form
    {
        private DataGridView test11;


        private static HLogs Hlogs = null;
        public HLogs()
        {
            InitializeComponent();
            test11 = dbstuff.homelog(dgv, User.UserID);

        }

        public static Form getInstance()
        {
            if (Hlogs == null)
            {
                Hlogs = new HLogs();
            }

            return Hlogs;
        }



    }
}
