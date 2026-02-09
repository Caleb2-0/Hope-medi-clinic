using MySql.Data.MySqlClient;
using System;

namespace HospitalSystem.Classes
{
    internal class diagonosis
    {
        connection connect = new connection();

        public bool addD(string diag_id, string app_id, string symp, string test, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `diagonosis`(`diagonosis_id`,`app_id`,`symptoms`,`test`,`date`) VALUES (@did,@aid,@sp,@ts,@dt)", connect.GetSqlConnection);
            command.Parameters.Add("@did", MySqlDbType.VarChar).Value = diag_id;
            command.Parameters.Add("@aid", MySqlDbType.VarChar).Value = app_id;
            command.Parameters.Add("@sp", MySqlDbType.VarChar).Value = symp;
            command.Parameters.Add("@ts", MySqlDbType.VarChar).Value = test;
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
        public bool updt(string dig_id, string result)
        {
            MySqlCommand command = new MySqlCommand("UPDATE diagonosis SET result = @res WHERE diagonosis_id = @did", connect.GetSqlConnection);
            command.Parameters.Add("@did", MySqlDbType.VarChar).Value = dig_id;
            command.Parameters.Add("@res", MySqlDbType.VarChar).Value = result;

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
