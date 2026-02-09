using MySql.Data.MySqlClient;
using System;

namespace HospitalSystem.Classes
{
    internal class prescriptions
    {
        connection connect = new connection();

        public bool addpresT(string pre_id,string diagonosis_id, string invent_id, int quantity, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `prescriptions_temp`(`pre_id`,`diagonosis_id`,`invent_id`,`quantity`,`date`) VALUES (@pid,@did,@id,@qt,@dt)", connect.GetSqlConnection);
            command.Parameters.Add("@did", MySqlDbType.VarChar).Value = diagonosis_id;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = invent_id;
            command.Parameters.Add("qt", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("dt", MySqlDbType.Date).Value = date;
            command.Parameters.Add("pid", MySqlDbType.VarChar).Value = pre_id;

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

        public bool addpres(string pre_id,string diagonosis_id, string invent_id, int quantity, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `prescriptions`(`pre_id`,`diagonosis_id`,`invent_id`,`quantity`,`date`) VALUES (@pid,@did,@id,@qt,@dt)", connect.GetSqlConnection);
            command.Parameters.Add("@did", MySqlDbType.VarChar).Value = diagonosis_id;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = invent_id;
            command.Parameters.Add("qt", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("pid", MySqlDbType.VarChar).Value = pre_id;
            command.Parameters.Add("dt", MySqlDbType.Date).Value = date;

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
        public bool removp(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM prescriptions_temp WHERE id = @id", connect.GetSqlConnection);
            command.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;

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
