﻿using System;
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
            int selectedValue = (int)SizeCB.SelectedValue;
            if(hName.Text == "")
            {

                 MessageBox.Show("House Name fields are blank.",
                    "House Name fields are blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dbstuff.createHouse(hName.Text, selectedValue, selectedValue, "Off") == true )
            {
                MessageBox.Show("House has been created",
                     "House has been created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            test = dbstuff.cbFill(dataGridView1, User.UserID);

            ;
            //   Console.WriteLine(dbstuff.createHouse(hName.Text, selectedValue, selectedValue, "Off"));
            //MessageBox.Show("House has been created",
            //    "House has been created", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            // Console.WriteLine(SizeCB.Items);

            //test = CStuff.creatDG(test1, selectedValue, selectedValue);
            //Console.WriteLine(selectedValue);

            //// // add table to form
            //getInstance().Controls.Add(test);

            // set the form size to be the table with some padding
            // int padding = START_LOCATION * 2;
            //  getInstance().ClientSize = new Size(test.Height + padding, test.Width + padding);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SizeCB.Items.Clear();
            int[] data = { 2, 3, 4, 5, 6, 7, 8, 9, 10};
            SizeCB.DataSource = data;
            SizeCB.SelectedIndex = 0;
            test = dbstuff.cbFill(dataGridView1, User.UserID);

        }

        private void dHouse_Click(object sender, EventArgs e)
        {
            //    int t = (int)HousesCB.SelectedValue;
            dbstuff.deleteHouse(House.HomeIDs);
            Console.WriteLine(House.HomeIDs);
            MessageBox.Show("House has been deleted.",
                   "House Name fields are blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            test = dbstuff.cbFill(dataGridView1, User.UserID);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int value1 = Convert.ToInt32(row.Cells[0].Value.ToString());
                string value2 = row.Cells[1].Value.ToString();
                //...
                House.homeIDs = value1;
                Console.WriteLine(value1);
            }

        }
    }
}
