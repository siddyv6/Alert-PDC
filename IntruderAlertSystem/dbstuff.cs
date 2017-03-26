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
            return user;
        }


        public static bool deleteHouse(int houseID)
        {
            MySqlConnection con = DBConection();
            string sql = "DELETE FROM `alarm`.`home` WHERE `idhome`= @name";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", houseID);

            //MySqlParameter paramUsername = new MySqlParameter("@name", MySqlDbType.VarChar);
            //  paramUsername.Value = username;
            //cmd.Parameters.Add(paramUsername);

            bool user = false;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

             
                    user = true;
                

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

            string[,] workThrough = new string[x, y];
            

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

        public static House getHouseAndRooms(int userID)
        {
            House home = getHouse(userID);

            if (home != null)
            {
                Room[] rooms = getRoomsAndSensorsFromFloor(home.Idhome);

                foreach (Room room in rooms)
                {
                    home.Rooms[room.X, room.Y] = room;
                }
            }

            return home;
        }

        public static Room[] getRoomsFromFloor(int homeID)
        {
            MySqlConnection con = DBConection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rooms WHERE idhome = @homeID", con);
            cmd.Parameters.Add(new MySqlParameter("@homeID", homeID));

            Room[] rooms = null;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();
                List<Room> roomList = new List<Room>();

                while (reader.Read())
                {
                    Room room = new Room();

                    room.RoomID = reader.GetInt32("idrooms");
                    room.X = reader.GetInt32("x");
                    room.Y = reader.GetInt32("y");
                    room.DoorLocations = reader.GetString("DLocation");

                    string t = reader.GetString("roomsType");
                    room.Type = CStuff.convertMySQLEnumToCSharpEnum<RoomType>(t);

                    string c = reader.GetString("RLocation");
                    room.Category = CStuff.convertMySQLEnumToCSharpEnum<RLocation>(c);

                    roomList.Add(room);
                }

                reader.Close();
                rooms = roomList.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return rooms;
        }

        public static Room[] getRoomsAndSensorsFromFloor(int homeID)
        {
            Room[] rooms = getRoomsFromFloor(homeID);

            if (rooms != null)
            {
                foreach (Room room in rooms)

                {
                    Sensor[] sensors = null;

                    //room.Sensors = getSensorsFromRoom(room.RoomID);
                    MySqlConnection connn = DBConection();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sensor WHERE idrooms = @roomID", con);
                    cmd.Parameters.Add(new MySqlParameter("@roomID", room.RoomID));

                    //Sensor[] sensors = null;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MySqlDataReader reader = cmd.ExecuteReader();
                        List<Sensor> sensorList = new List<Sensor>();

                        while (reader.Read())
                        {
                            Sensor sensor = new Sensor();

                            sensor.SensorID = reader.GetInt32("idsensor");
                            sensor.Value = reader.GetString("v");

                            string t = reader.GetString("sensorTypes");
                            sensor.Type = CStuff.convertMySQLEnumToCSharpEnum<SensorTypeEnum>(t);

                            //string s = reader.GetString("state");
                            //sensor.State = Common.convertMySQLEnumToCSharpEnum<AlarmState>(s);

                            sensorList.Add(sensor);
                        }

                        reader.Close();
                        sensors = sensorList.ToArray();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }

                    room.Sensors = sensors;

                }
            }

            return rooms;
        }

        //public static Sensor[] getSensorsFromRoom(int roomID)
        //{
        //    MySqlConnection con = DBConection();
        //    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sensor WHERE idrooms = @roomID", con);
        //    cmd.Parameters.Add(new MySqlParameter("@roomID", roomID));

        //    Sensor[] sensors = null;

        //    try
        //    {
        //        con.Open();
        //        cmd.ExecuteNonQuery();

        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        List<Sensor> sensorList = new List<Sensor>();

        //        while (reader.Read())
        //        {
        //            Sensor sensor = new Sensor();

        //            sensor.SensorID = reader.GetInt32("idsensor");
        //            sensor.Value = reader.GetString("v");

        //            string t = reader.GetString("sensorTypes");
        //            sensor.Type = CStuff.convertMySQLEnumToCSharpEnum<SensorTypeEnum>(t);

        //            //string s = reader.GetString("state");
        //            //sensor.State = Common.convertMySQLEnumToCSharpEnum<AlarmState>(s);

        //            sensorList.Add(sensor);
        //        }

        //        reader.Close();
        //        sensors = sensorList.ToArray();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //    return sensors;
        //}

        public static House getHouse(int houseid)
        {
            MySqlConnection con1 = DBConection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM home WHERE idhome = @houseID", con1);
            cmd.Parameters.Add(new MySqlParameter("@houseID", houseid));

            House home = null;

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    home = new House();
                    home.Idhome = reader.GetInt32("idhome");
                    House.HomeIDs = reader.GetInt32("idhome");
                    home.size = reader.GetInt32("x");
                    string s = reader.GetString("alarmS");
                    home.State = CStuff.convertMySQLEnumToCSharpEnum<AlarmS>(s);
                    home.HName = reader.GetString("hName");
                    int x = reader.GetInt32("x");
                    int y = reader.GetInt32("y");

                    home.Rooms = new Room[x, y];
                }
                else {
                    Console.WriteLine($"No home with user ID of '{houseid}' found.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con1.Close();
            }

            return home;
        }

        public static DataGridView cbFill(DataGridView dgv, int userID)
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
                BindingSource bSource = new BindingSource();
                bSource.DataSource = daTbl;
                dgv.DataSource = bSource;
               // daTbl.Columns.Add("idHome", typeof(int));

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
