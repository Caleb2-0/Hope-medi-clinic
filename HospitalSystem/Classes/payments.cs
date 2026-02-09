using MySql.Data.MySqlClient;
using System;

namespace HospitalSystem.Classes
{
    internal class payments
    {
        connection connect = new connection();

        //adding payment

        public bool addp(string payment_id, string order_id, string cheque, double amount, string purpose, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `payments`(`payment_id`,`order_id`,`cheque_number`,`amount`,`purpose`,`date`) VALUES (@pid,@oid,@cn,@amount,@pp,@dt)", connect.GetSqlConnection);
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = payment_id;
            command.Parameters.Add("@oid", MySqlDbType.VarChar).Value = order_id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cheque;
            command.Parameters.Add("@pp", MySqlDbType.VarChar).Value = purpose;
            command.Parameters.Add("@amount", MySqlDbType.Double).Value = amount;
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

        public bool addop(string payment_id, string name, string cheque, double amount, DateTime date, string purpose)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `payments`(`payment_id`,`name`,`cheque_number`,`amount`,`date`,`purpose`) VALUES (@pid,@nm,@cn,@amnt,@dt,@ps)", connect.GetSqlConnection);
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = payment_id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cheque;
            command.Parameters.Add("@amnt", MySqlDbType.Double).Value = amount;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = purpose;

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
