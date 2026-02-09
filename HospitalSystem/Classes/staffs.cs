using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace HospitalSystem.Classes
{
    internal class staffs
    {
        connection conn = new connection();
        public string fname { set; get; }
        public string lname { set; get; }
        public string address { set; get; }
        public string phone { set; get; }
        public string email { set; get; }
        public string uname { set; get; }
        public string design { set; get; }
        public string id { set; get; }

        public bool add_staff(string id, string fname, string lname, string gender, int age, DateTime dob, string address, string phone, string email, string uname, string password, string design)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `staffs`(`staff_id`,`first_name`,`last_name`,`gender`,`date_of_birth`,`age`,`address`,`phone_number`,`email`,`username`,`password`,`role`) " +
                "VALUES(@id,@fname,@lname,@gen,@dob,@age,@address,@phone,@email,@uname,@pw,@role)", conn.GetSqlConnection);
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = design;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", MySqlDbType.DateTime).Value = dob;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = age;

            conn.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnect();
                return true;
            }
            else
            {
                conn.closeConnect();
                return false;
            }
        }

        //function for updating staff record
        public bool update(string staff_id, string fname, string lname, string address, string phone, string email, string uname, string role)
        {
            MySqlCommand command = new MySqlCommand("UPDATE staffs SET  first_name = @name,last_name = @lname, address = @add,phone_number = @phone, email = @email,username = @uname,role = @role WHERE staff_id = @id",
            conn.GetSqlConnection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = staff_id;

            conn.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnect();
                return true;
            }
            else
            {
                conn.closeConnect();
                return false;
            }
        }

        //function for resetting passwords

        public bool reset(string staff_id, string pass)
        {
            MySqlCommand command = new MySqlCommand("UPDATE staffs SET password = @pass WHERE staff_id = @id",
            conn.GetSqlConnection);
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = staff_id;

            conn.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnect();
                return true;
            }
            else
            {
                conn.closeConnect();
                return false;
            }
        }

        public bool updatep(string uname, string pass)
        {
            MySqlCommand command = new MySqlCommand("UPDATE staffs SET password = @pass WHERE username = @un",
            conn.GetSqlConnection);
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = uname;

            conn.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnect();
                return true;
            }
            else
            {
                conn.closeConnect();
                return false;
            }
        }

        public bool checkuname(string uname)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM staffs WHERE username = @user", conn.GetSqlConnection);
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = uname;

            conn.openConnect();

            MySqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count >= 1)
            {
                conn.closeConnect();
                return true;
            }
            else
            {
                conn.closeConnect();
                return false;
            }
        }

        //function for deleting a staff record
        public bool delete_user(string staff_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM staffs WHERE staff_id = @staffid", conn.GetSqlConnection);

            command.Parameters.Add("@staffid", MySqlDbType.VarChar).Value = staff_id;

            conn.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnect();
                return true;
            }
            else
            {
                conn.closeConnect();
                return false;
            }
        }

        public static string userid()
        {
            Random ran = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYXabcdefghijklmnopqrstuvwxyz0123456789";
            char[] userIdChars = new char[10];
            for (int i = 0; i < userIdChars.Length; i++)
            {
                userIdChars[i] = chars[ran.Next(chars.Length)];
            }
            return new string(userIdChars);
        }
        public static int Age(int dob)
        {
            int date = DateTime.Now.Year;
            int age = 0;
            age = date - dob;
            return age;
        }

        //getting database records
        public DataTable view_db_records(MySqlCommand command)
        {
            command.Connection = conn.GetSqlConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
