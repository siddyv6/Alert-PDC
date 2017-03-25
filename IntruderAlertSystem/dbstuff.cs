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

        public static void createUser(string username, string password)
        {
            MySqlConnection con = DBConection();
            string sql = "INSERT INTO user (Name, PasswordHash) VALUES (@uname, @pw);";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@uname", username);
            cmd.Parameters.AddWithValue("@pw", password);
           // cmd.Parameters.AddWithValue("@salt", salt);

           // MySqlParameter paramUsername = new MySqlParameter("@uname", MySqlDbType.VarChar);
            //MySqlParameter paramPw = new MySqlParameter("@pw", MySqlDbType.VarBinary);
            //MySqlParameter paramSalt = new MySqlParameter("@salt", MySqlDbType.VarBinary);

           // paramUsername.Value = username;
           // paramPw.Value = password;
           // paramSalt.Value = salt;

            //cmd.Parameters.Add(paramUsername);
            //cmd.Parameters.Add(paramPw);
            //cmd.Parameters.Add(paramSalt);

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
            string sql = "SELECT PasswordHash FROM user WHERE Name = @uname";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@uname", username);

            con.Open();
            cmd.ExecuteNonQuery();

            MySqlDataReader reader;
           // string salt = null;
            string storedPw = null;

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                   // salt = (string)reader["PasswordSalt"];
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

            return Encryption.ValidatePassword(password, storedPw);
        }
    }
    }
