using MySql.Data.MySqlClient;
using System;

namespace HospitalSystem.Classes
{
    internal class login
    {
        public string Username { set; get; }
        public string Password { set; get; }

        connection connect = new connection();

        public bool user_login(string username, string password)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM staffs WHERE username = @user AND password = @pass", connect.GetSqlConnection);
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            connect.openConnect();

            MySqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        public string Role(string username, string password)
        {
            connection connect = new connection();

            MySqlCommand com = new MySqlCommand("select role from users as role", connect.GetSqlConnection);
            connect.openConnect();
            MySqlDataReader reader = com.ExecuteReader();
            string role = "";
            while (reader.Read())
            {
                role = reader.GetString(1);
            }
            connect.closeConnect();
            return role;



        }

        public bool login_log(string staff_id, string login_t, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `logs`(`staff_id`,`login_time`,`date`) VALUES (@sid,@lgt,@dt)", connect.GetSqlConnection);
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = staff_id;
            command.Parameters.Add("@lgt", MySqlDbType.VarChar).Value = login_t;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;

            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }
        public bool logout_log(string staff_id, string logout_, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("UPDATE logs SET logout_time = @lgot WHERE staff_id = @id AND date = @dt", connect.GetSqlConnection);
            command.Parameters.Add("@lgot", MySqlDbType.VarChar).Value = logout_;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = staff_id;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;

            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }

    }
}
