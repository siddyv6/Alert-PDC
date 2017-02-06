using Alarm;
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

namespace IntruderAlertSystem {
    public partial class Login : Form {

        private static Login login = null;

        public Login() {
            InitializeComponent();
            testDBConnection();

        }

        public void testDBConnection()
        {
            MySqlConnection con = Alarm.dbstuff.DBConection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE userID=@UID", con);
            cmd.Parameters.Add(new MySqlParameter("@UID", 1));

            con.Open();
            cmd.ExecuteNonQuery();

            DataSet ds = new DataSet();
            MySqlDataAdapter dAdap = new MySqlDataAdapter();
            dAdap.SelectCommand = cmd;
            dAdap.Fill(ds, "Name");

            MySqlDataReader reader;

            try
            {
                //string uname = ds.Tables["Username"].Rows[0].ToString();
                //Console.WriteLine(String.Format("username is: '{0}'", uname));

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string s = reader.GetString("Name");
                    Console.WriteLine(String.Format("username is: '{0}'", s));
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static Form getInstance() {
            if (login == null) {
                login = new Login();
            }

            return login;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (uNameTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Both Username and Password fields are mandatory, please fill them in.",
                    "Username or password fields are blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool validUser = dbstuff.decrypteUser(uNameTxt.Text, passwordTxt.Text);

            if (validUser)
            {
                //authenticated.getInstance().Show();
                getInstance().Hide();
            }
            else {
                MessageBox.Show("Your username or password is incorrect, please try again or register a new account.",
                    "Username or password incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            Register.getInstance().Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            uNameTxt.Text = "";
            passwordTxt.Text = "";
        }
    }
}
