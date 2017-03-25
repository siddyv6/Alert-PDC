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

        private void button1_Click(object sender, EventArgs e)
        {
            // https://msdn.microsoft.com/en-us/library/aa984255(v=vs.71).aspx
            DataGridView test = new DataGridView();
            test.DataSource = null;

            // Remove headings because we only want cells,
            // which makes the table look more like a floor plan.
            test.RowHeadersVisible = false;
            test.ColumnHeadersVisible = false;

            // setup number of rooms
            test.ColumnCount = Convert.ToInt32(X.Text);
            test.RowCount = Convert.ToInt32(Y.Text);

            // set start location to top-left corner
            const int START_LOCATION = 25;
            test.Location = new Point(START_LOCATION, START_LOCATION);

            // set cell lengths to be square and decently sized, so it represents a "room"
            const int CELL_LENGTH = 100;

            foreach (DataGridViewColumn column in test.Columns)
            {
                column.Width = CELL_LENGTH;
            }

            foreach (DataGridViewRow row in test.Rows)
            {
                row.Height = CELL_LENGTH;
            }

            // set the size of the table to be the perfect fit (no scroll bars / blank space)
            // http://stackoverflow.com/questions/7412098/fit-datagridview-size-to-rows-and-columnss-total-size
            // http://stackoverflow.com/questions/6651487/programmatically-resize-datagridview-to-remove-scroll-bars
            int borderOffset = (test.BorderStyle == BorderStyle.None) ? 0 : 2;

            int newHeight = test.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + borderOffset;
            int newWidth = test.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + borderOffset;

            // set the adjusted size and remove the redundant scroll bars
            test.ClientSize = new Size(newHeight, newWidth);
            test.ScrollBars = ScrollBars.None;

            // add table to form
            getInstance().Controls.Add(test);

            // set the form size to be the table with some padding
            int padding = START_LOCATION * 2;
            getInstance().ClientSize = new Size(test.Height + padding, test.Width + padding);
        }
    }
}
