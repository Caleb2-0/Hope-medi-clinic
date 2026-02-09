using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace HospitalSystem.Classes
{
    internal class clients
    {
        connection conn = new connection();
        public string fname { set; get; }
        public string lname { set; get; }
        public string address { set; get; }
        public string phone { set; get; }
        public string email { set; get; }
        public string id { set; get; }

        public bool add_client(string id, string fname, string lname, string gender, int age, DateTime dob, string address, string phone, string email)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `clients`(`client_id`,`first_name`,`last_name`,`gender`,`date_of_birth`,`age`,`address`,`phone_number`,`email`) " +
                "VALUES(@id,@fname,@lname,@gen,@dob,@age,@address,@phone,@email)", conn.GetSqlConnection);
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
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

        //function for updating client record
        public bool update(string id, string fname, string lname, string gender, int age, DateTime dob, string address, string phone, string email)
        {
            MySqlCommand command = new MySqlCommand("UPDATE clients SET  first_name = @name,last_name = @lname,gender = @gen,date_of_birth = @dob,age = @age, address = @add,phone_number = @phone, email = @email WHERE client_id = @cid",
            conn.GetSqlConnection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", MySqlDbType.DateTime).Value = dob;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = age;
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = id;

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
        public bool updtP(string client_id, string condition)
        {
            MySqlCommand command = new MySqlCommand("UPDATE clients SET  past_conditions = @pc WHERE client_id = @id",
            conn.GetSqlConnection);
            command.Parameters.Add("@pc", MySqlDbType.VarChar).Value = condition;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = client_id;

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

        //function for deleting a client record
        public bool delete_client(string c_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM clients WHERE client_id = @cid", conn.GetSqlConnection);

            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = c_id;

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
