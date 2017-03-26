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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Shom_Click(object sender, EventArgs e)
        {

            // Console.WriteLine(SizeCB.Items);
            int selectedValue = (int)vHouses.SelectedValue;
            Console.WriteLine(selectedValue);

            test = CStuff.creatDG(dgv, selectedValue, selectedValue);
            //Console.WriteLine(selectedValue);

        }
    }
}
