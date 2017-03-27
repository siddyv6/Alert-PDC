using MySql.Data.MySqlClient;
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
    public partial class EHome : Form
    {
        private static EHome Ehome = null;
        public int idSensor;

        private static House home = null;
        private static Room[,] room ;
        private static Room[] roomss;
        private static string Test;
        public int idRoom;

        public enum Locations
        {
            North,
            East,
            South,
            West
        }
        public EHome()
        {
            InitializeComponent();
        }
        private DataGridView test;

        private DataGridView slis;

        public static Form getInstance()
        {
            if (Ehome == null)
            {
                Ehome = new EHome();
            }

            return Ehome;
        }

        private void EHome_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = dbstuff.DBConection();

                string selectQuery = "SELECT * FROM alarm.home where userID=@userid";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@userid", User.UserID);
                Console.WriteLine(User.UserID);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    vHouses.Items.Add(reader.GetString("idhome"));
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CStuff.fillComboBoxFromEnum<RLocation>(ref CBCat);
            CStuff.fillListBoxFromEnum<Locations>(ref CLDL);
            CStuff.fillComboBoxFromEnum<RoomType>(ref CBType);
            CStuff.fillComboBoxFromEnum<SensorTypeEnum>(ref sensorTypess);

        }

        private void Shom_Click(object sender, EventArgs e)
        {
            Shom.Enabled = false;

            // Console.WriteLine(SizeCB.Items);
            string selectedValue = (string)vHouses.SelectedItem;
            Console.WriteLine(selectedValue);
            //Intialize Rooms Array
            room = new Room[Convert.ToInt32(selectedValue), Convert.ToInt32(selectedValue)];

            //Console.WriteLine(selectedValue);
            home = dbstuff.getHouseAndRooms(Convert.ToInt32(selectedValue));
          //  room = dbstuff.getRoomsAndSensorsFromFloor(Convert.ToInt32(selectedValue));
            test = CStuff.creatDG(dgv, home.size, home.size);
            Console.WriteLine(home.size);
            
            roomss = dbstuff.getRoomsFromFloor(home.Idhome);
            foreach(Room room in roomss)
                {
                dgv.Rows[room.X].Cells[room.Y].Value = room.Type + room.DLocations;
                
            }
           // Console.WriteLine(roomss[0].RoomID);
          //  Console.WriteLine(home.Rooms[home.Idhome, home.Idhome]);
          
           // home.Rooms[home.size,home.size];
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XX.Text = e.RowIndex.ToString();
           
            YY.Text = e.ColumnIndex.ToString();
            int x = Int32.Parse(XX.Text);
            int y = Int32.Parse(YY.Text);
            // limit doors to inside the house(no doors at edges)
            Locations cp = (Locations)CLDL.SelectedItem;
            int cellX = dgv.SelectedCells[0].ColumnIndex;
            int cellY = dgv.SelectedCells[0].RowIndex;

            // http://stackoverflow.com/questions/3816718/how-to-get-an-array-of-all-enum-values-in-c
            List<Locations> compassPoints = Enum.GetValues(typeof(Locations)).Cast<Locations>().ToList();

            // left-hand edges can't have doors on the left wall
            // prevent doors at left edge
            if (cellX == 0)
            {
                compassPoints.Remove(Locations.West);
            }

            // prevent doors at right edge
            if (cellX == dgv.ColumnCount - 1)
            {
                compassPoints.Remove(Locations.East);
            }

            // prevent doors at top edge
            if (cellY == 0)
            {
                compassPoints.Remove(Locations.North);
            }

            // prevent doors at bottom edge
            if (cellY == dgv.RowCount - 1)
            {
                compassPoints.Remove(Locations.South);
            }

            CLDL.DataSource = compassPoints;
            string selectedValue = (string)vHouses.SelectedItem;
            int r = Convert.ToInt32(selectedValue);
            idRoom = dbstuff.getRoomId(r, x, y);
            slis = dbstuff.getSList(SList, idRoom);

        }


    private void addRoom_Click(object sender, EventArgs e)
        {
            string selectedValue = (string)vHouses.SelectedItem;

           // room = new Room[Int32.Parse(XX.Text), Int32.Parse(YY.Text)];

           var op = (RoomType)Enum.Parse(typeof(RoomType), CBType.Text.Replace(' ', '_'));
            //  home.Rooms[Int32.Parse(XX.Text), Int32.Parse(YY.Text)] = ;
            //  Room room = home.Rooms[Int32.Parse(XX.Text), Int32.Parse(YY.Text)];
            int x = Int32.Parse(XX.Text);
            int y = Int32.Parse(YY.Text);
            room[x, y] = new Room();
            room[x, y].Type = (RoomType)Enum.Parse(typeof(RoomType), CBType.Text);
            Console.WriteLine(room[x, y].Type);

            Test = "";

            foreach (int i in CLDL.CheckedIndices)
            {
                Test += CLDL.Items[i].ToString();
            }

            Console.WriteLine(dbstuff.insertRoom(House.homeIDs, x, y,CBType.Text, Test));
            //  Console.WriteLine(room);
            //room[Int32.Parse(YY.Text), Int32.Parse(XX.Text)].Type = (RoomType)Enum.Parse(typeof(RoomType), CBType.Text.Replace(' ', '_')); 
           // Console.WriteLine(op);
            dgv.Rows[Int32.Parse(XX.Text)].Cells[Int32.Parse(YY.Text)].Value = CBType.Text;

            //Remake Table
            home = dbstuff.getHouseAndRooms(Convert.ToInt32(selectedValue));
            //  room = dbstuff.getRoomsAndSensorsFromFloor(Convert.ToInt32(selectedValue));
            test = CStuff.creatDG(dgv, home.size, home.size);
            Console.WriteLine(home.size);

            roomss = dbstuff.getRoomsFromFloor(home.Idhome);
            foreach (Room room in roomss)
            {
                dgv.Rows[room.X].Cells[room.Y].Value = room.Type + room.DLocations;

            }
        }

        private void CLDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Test = "";

            int selected = CLDL.SelectedIndex;
            if (selected != -1)
            {
                Test += CLDL.Items[selected].ToString();
            }
        }

        private void checkItemIfExists(ref CheckedListBox clb, Enum e)
        {
            // http://stackoverflow.com/questions/370820/how-do-i-programmatically-check-an-item-in-a-checkedlistbox-in-c-sharp
            if (clb.Items.Contains(e))
            {
                int i = clb.Items.IndexOf(e);
                clb.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void removeSensor_Click(object sender, EventArgs e)
        {
            if(dbstuff.deleteSensor(idSensor) != false)
            {
                Console.WriteLine();
                MessageBox.Show("Sensor has been deleted.",
                       "Sensor has been deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //       test = dbstuff.cbFill(dataGridView1, User.UserID);
                slis = dbstuff.getSList(SList, idRoom);
              
            } else
            {
                MessageBox.Show("Please Choose a sensor to Delete or Add Sensors to the room",
                "Please Choose a sensor to Delete or Add Sensors to the room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        

        }

        private void addSensor_Click(object sender, EventArgs e)
        {
            if(idRoom==0)
            {
                MessageBox.Show("Choose a Room first",
                  "Choose a Room first", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                Console.WriteLine(dbstuff.insertSensor(idRoom, sensorTypess.Text, sValue.Text));
                MessageBox.Show("Sensor has been Added.",
                       "Sensor has been Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //       test = dbstuff.cbFill(dataGridView1, User.UserID);
                slis = dbstuff.getSList(SList, idRoom);
            }
        

        }

        private void SList_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SList.SelectedRows)
            {
                int value1 = Convert.ToInt32(row.Cells[0].Value.ToString());
                string value2 = row.Cells[1].Value.ToString();
                //...
                idSensor = value1;
                Console.WriteLine(idSensor);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbstuff.alterSValue(idSensor, sValue.Text);
            slis = dbstuff.getSList(SList, idRoom);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CBCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
