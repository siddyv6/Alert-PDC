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
        private static House home = null;
        private static Room[,] room ;
        private static Room[] roomss;

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

        }

        private void Shom_Click(object sender, EventArgs e)
        {

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
          //  Console.WriteLine(home.Rooms[home.Idhome, home.Idhome]);
          
           // home.Rooms[home.size,home.size];
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XX.Text = e.RowIndex.ToString();
           
            YY.Text = e.ColumnIndex.ToString();

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

        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            string selectedValue = (string)vHouses.SelectedItem;

           // room = new Room[Int32.Parse(XX.Text), Int32.Parse(YY.Text)];

           // var op = (RoomType)Enum.Parse(typeof(RoomType), CBType.Text.Replace(' ', '_'));
            //  home.Rooms[Int32.Parse(XX.Text), Int32.Parse(YY.Text)] = ;
            //  Room room = home.Rooms[Int32.Parse(XX.Text), Int32.Parse(YY.Text)];
            int x = Int32.Parse(XX.Text);
            int y = Int32.Parse(YY.Text);
            room[x, y] = new Room();
            room[x, y].Type = (RoomType)Enum.Parse(typeof(RoomType), CBType.Text);

            //  Console.WriteLine(room);
            //room[Int32.Parse(YY.Text), Int32.Parse(XX.Text)].Type = (RoomType)Enum.Parse(typeof(RoomType), CBType.Text.Replace(' ', '_')); 
           // Console.WriteLine(op);
            dgv.Rows[Int32.Parse(XX.Text)].Cells[Int32.Parse(YY.Text)].Value = CBType.Text;
        }
    }
}
