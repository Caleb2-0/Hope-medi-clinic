using MySql.Data.MySqlClient;

namespace HospitalSystem.Classes
{
    internal class suppliers
    {
        connection conn = new connection();
        public string name { set; get; }
        public string payment { set; get; }
        public string address { set; get; }
        public string phone { set; get; }
        public string email { set; get; }
        public string id { set; get; }
        public string delivery { set; get; }

        //for adding suppliers
        public bool add_supplier(string id, string name, string address, string phone, string email, string payment, string delivery)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `suppliers`(`supplier_id`,`name`,`address`,`phone_number`,`email`,`payment_terms`,`delivery_terms`) " +
                "VALUES(@id,@name,@ad,@pn,@em,@pt,@dt)", conn.GetSqlConnection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = payment;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = delivery;

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

        //function for updating supplier record
        public bool update(string id, string name, string address, string phone, string email, string payment, string delivery)
        {
            MySqlCommand command = new MySqlCommand("UPDATE suppliers SET  name = @name, address = @ad,phone_number = @pn, email = @em,payment_terms = @pt,delivery_terms = @dt WHERE supplier_id = @sid",
            conn.GetSqlConnection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = payment;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = delivery;

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


        //function for deleting a supplier record
        public bool delete_sup(string s_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM suppliers WHERE supplier_id = @sid", conn.GetSqlConnection);

            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = s_id;

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
    }
}
