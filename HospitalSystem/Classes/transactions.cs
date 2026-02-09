using MySql.Data.MySqlClient;
using System;

namespace HospitalSystem.Classes
{
    internal class transactions
    {
        connection conn = new connection();

        public bool addtemp(string invent_id, int quantity, float cost, DateTime date, string pre_id, string trans_id)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `receipt_temp`(`invent_id`,`quantity`,`cost`,`date`,`pre_id`,`trans_id`) VALUES (@id,@qt,@ct,@dt,@pid,@tid)", conn.GetSqlConnection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = invent_id;
            command.Parameters.Add("@qt", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("@ct", MySqlDbType.Float).Value = cost;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = pre_id;
            command.Parameters.Add("@tid", MySqlDbType.VarChar).Value = trans_id;

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

        public bool addtemps(string service_id,float cost,DateTime date,string trans_id)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `receipt_temp`(`service_id`,`cost`,`date`,`trans_id`) VALUES (@id,@ct,@dt,@tid)", conn.GetSqlConnection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = service_id;
            command.Parameters.Add("@ct", MySqlDbType.Float).Value = cost;
            command.Parameters.Add("@tid", MySqlDbType.VarChar).Value = trans_id;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;


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
        public bool addTrans(string trans_id, string pre_id,string service_id, float amount, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `transactions`(`trans_id`,`pre_id`,`service_id`,`amount`,`date`) VALUES (@tid,@pid,@sid,@am,@d)", conn.GetSqlConnection);
            command.Parameters.Add("@d", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = pre_id;
            command.Parameters.Add("@tid", MySqlDbType.VarChar).Value = trans_id;
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = service_id;
            command.Parameters.Add("@am", MySqlDbType.Float).Value = amount;

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

        public bool addTransSer(string trans_id, string pre_id, string service_id, float amount, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `transactions`(`trans_id`,`pre_id`,`service_id`,`amount`,`date`) VALUES (@tid,@pid,@sid,@am,@d)", conn.GetSqlConnection);
            command.Parameters.Add("@d", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = pre_id;
            command.Parameters.Add("@tid", MySqlDbType.VarChar).Value = trans_id;
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = service_id;
            command.Parameters.Add("@am", MySqlDbType.Float).Value = amount;

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
        public bool delTrans(int temp_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM receipt_temp WHERE temp_id = @d", conn.GetSqlConnection);
            command.Parameters.Add("@d", MySqlDbType.Int32).Value = temp_id;

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
