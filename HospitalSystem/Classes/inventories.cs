using MySql.Data.MySqlClient;
using System.Data;

namespace HospitalSystem.Classes
{
    internal class inventories
    {
        connection connect = new connection();

        //for adding inventory
        public bool addinvt(string invent_id, string name, string unit, float costp, float selling_p, int quantity)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO inventory (`invent_id`,`name`,`unit`,`cost_price`,`selling_price`,`quantity`) " +
                "VALUES (@intid,@name,@unit,@cp,@sp,@qnty)",
            connect.GetSqlConnection);
            command.Parameters.Add("@intid", MySqlDbType.VarChar).Value = invent_id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@unit", MySqlDbType.VarChar).Value = unit;
            command.Parameters.Add("@cp", MySqlDbType.Float).Value = costp;
            command.Parameters.Add("@sp", MySqlDbType.Float).Value = selling_p;
            command.Parameters.Add("@qnty", MySqlDbType.Int32).Value = quantity;

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

        public bool updateinvt(string invent_id, string name, string unit, float costp, float sellingp, int quantity)
        {
            MySqlCommand command = new MySqlCommand("UPDATE inventory SET name = @name,unit = @uni,cost_price =@cp,selling_price = @sp,quantity = @qt WHERE invent_id = @id", connect.GetSqlConnection);
            command.Parameters.Add("name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("uni", MySqlDbType.VarChar).Value = unit;
            command.Parameters.Add("cp", MySqlDbType.Float).Value = costp;
            command.Parameters.Add("sp", MySqlDbType.Float).Value = sellingp;
            command.Parameters.Add("qt", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("id", MySqlDbType.VarChar).Value = invent_id;

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

        public bool delinvt(string id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM inventory WHERE invent_id = @id", connect.GetSqlConnection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

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

        public bool addsrv(string svc_id, string name, float cost)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO services (`service_id`,`s_name`,`cost`) " +
                "VALUES (@svcid,@name,@cost)",
            connect.GetSqlConnection);
            command.Parameters.Add("@svcid", MySqlDbType.VarChar).Value = svc_id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@cost", MySqlDbType.VarChar).Value = cost;

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

        public bool updtsvc(string svc_id, string name, float cost)
        {
            MySqlCommand command = new MySqlCommand("UPDATE services SET s_name = @name,cost = @cst WHERE service_id = @id", connect.GetSqlConnection);
            command.Parameters.Add("name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("cst", MySqlDbType.Float).Value = cost;
            command.Parameters.Add("id", MySqlDbType.VarChar).Value = svc_id;

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

        public bool delsvc(string id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM services WHERE service_id = @id", connect.GetSqlConnection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

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

        public bool addsupid(string invent_id, string supplier_id)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO inventory_supplier (`invent_id`,`supplier_id`) " +
                "VALUES (@inid,@supid)",
            connect.GetSqlConnection);
            command.Parameters.Add("@inid", MySqlDbType.VarChar).Value = invent_id;
            command.Parameters.Add("@supid", MySqlDbType.VarChar).Value = supplier_id;

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

        public bool checkinv(string name)
        {
            MySqlCommand command = new MySqlCommand("SELECT name FROM inventory where name = @name", connect.GetSqlConnection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

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

        public static int count()
        {
            connection connect = new connection();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) AS count FROM inventory WHERE quantity < 30", connect.GetSqlConnection);
            connect.openConnect();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows.Count;
            }
            else
            {
                return 0;
            }


        }

        public bool updtQ(string invent_id, int quantity)
        {
            MySqlCommand command = new MySqlCommand("UPDATE inventory SET quantity = @qt WHERE invent_id = @id", connect.GetSqlConnection);
            command.Parameters.Add("qt", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("id", MySqlDbType.VarChar).Value = invent_id;

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
