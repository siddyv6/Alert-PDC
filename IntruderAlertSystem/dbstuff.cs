using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    class dbstuff
    {

        private static MySqlConnection con = null;

        public static MySqlConnection DBConection()
        {
            if (con == null)
            {
                string connectionString = "Server=localhost;Database=alarm;Uid=sid;Pwd=Password1";
                con = new MySqlConnection(connectionString);
            }

            return con;
        }

        public static bool uniqueUsername(string username)
        {
            MySqlConnection con = DBConection();
            string sql = "SELECT Name FROM user WHERE Name = @name";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", username);

            //MySqlParameter paramUsername = new MySqlParameter("@name", MySqlDbType.VarChar);
          //  paramUsername.Value = username;
            //cmd.Parameters.Add(paramUsername);

            bool user = false;
            MySqlDataReader reader;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = true;
                }

                reader.Close();
            }
            catch (MySqlException E)
            {
                MessageBox.Show("Can not open connection ! ");
                throw E;
            }
            finally
            {
                con.Close();
            }
            return !user;
        }

        public static bool createHouse(string hName, int x, int y, string alarmS)
        {
            MySqlConnection con = DBConection();
            string sql = "INSERT INTO `alarm`.`home` (`userID`, `hName`, `x`, `y`, `alarmS`) VALUES (@userID, @hName, @x, @y, @state)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@userID", User.UserID);
            cmd.Parameters.AddWithValue("@hName", hName);
            cmd.Parameters.AddWithValue("@x", x);
            cmd.Parameters.AddWithValue("@y", y);
            cmd.Parameters.AddWithValue("@state", alarmS);

            //MySqlParameter paramUsername = new MySqlParameter("@name", MySqlDbType.VarChar);
            //  paramUsername.Value = username;
            //cmd.Parameters.Add(paramUsername);

            bool user = false;
          //  MySqlDataReader reader;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

              //  reader = cmd.ExecuteReader();
               
                    user = true;
                Console.WriteLine("Test");
             //   reader.Close();
            }
            catch (MySqlException E)
            {
                MessageBox.Show("Can not open connection ! ");
                throw E;
            }
            finally
            {
                con.Close();
            }
            return user;
        }

        public static DataGridView homelog(DataGridView dgv, int userID)
        {
            MySqlConnection con = DBConection();
            string sql = "SELECT * FROM alarm.homelog where idhome = any (SELECT idhome FROM home WHERE userID = @nameid )";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nameid", userID);

            //MySqlParameter paramUsername = new MySqlParameter("@name", MySqlDbType.VarChar);
            //  paramUsername.Value = username;
            //cmd.Parameters.Add(paramUsername);

           // MySqlDataReader reader;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable daTbl = new DataTable();
            da.Fill(daTbl);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = daTbl;
                dgv.DataSource = bSource;
               // con.Close();

            }
            catch (MySqlException E)
            {
                MessageBox.Show("Can not open connection ! ");
                throw E;
            }
            finally
            {
                con.Close();

            }
            return dgv;

        }

        public static ComboBox cbFill(ComboBox dgv, int userID)
        {
            MySqlConnection con = DBConection();
            string sql = "SELECT idHome,hName FROM alarm.home where userID = @nameid";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nameid", userID);

            //MySqlParameter paramUsername = new MySqlParameter("@name", MySqlDbType.VarChar);
            //  paramUsername.Value = username;
            //cmd.Parameters.Add(paramUsername);

            MySqlDataReader reader;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable daTbl = new DataTable();
                da.Fill(daTbl);
                //BindingSource bSource = new BindingSource();
                //bSource.DataSource = daTbl;
                dgv.DataSource = daTbl;
                //daTbl.Columns.Add("idHome", typeof(int));

                // con.Close();

            }
            catch (MySqlException E)
            {
                MessageBox.Show("Can not open connection ! ");
                throw E;
            }
            finally
            {
                con.Close();

            }
            return dgv;

        }

        public static void createUser(string username, string password)
        {
            MySqlConnection con = DBConection();
            string sql = "INSERT INTO user (Name, PasswordHash) VALUES (@uname, @pw);";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@uname", username);
            cmd.Parameters.AddWithValue("@pw", password);
    

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException MySqlE)
            {
                throw MySqlE;
            }
            finally
            {
                con.Close();
            }
        }


        public static bool decrypteUser(string username, string password)
        {
            MySqlConnection con = DBConection();
            string sql = "SELECT PasswordHash,userID FROM user WHERE Name = @uname";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@uname", username);

            con.Open();
            cmd.ExecuteNonQuery();

            MySqlDataReader reader;
            int userid = 01;
            string storedPw = null;

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userid = (int)reader["userID"];
                    storedPw = (string)reader["PasswordHash"];
                }
                else {
                    Console.WriteLine(String.Format("Username '{0}' not found.", username));
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


            if (storedPw == null)
            {
                return false;
            }
            User.UserID = userid;
            //Console.WriteLine(User.UserID);

            return Encryption.ValidatePassword(password, storedPw);
        }
    }
    }
