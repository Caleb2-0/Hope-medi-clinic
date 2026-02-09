using MySql.Data.MySqlClient;
using System;

namespace HospitalSystem.Classes
{
    internal class orders
    {
        connection connect = new connection();

        public bool add_order(string order_id, string invent_id, string supplier_id, int quantity, float total_coat, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `orders`(`order_id`,`invent_id`,`supplier_id`,`quantity`,`total_cost`,`date`)" +
                "VALUES (@ordid,@invid,@sid,@qnty,@cst,@dt)", connect.GetSqlConnection);
            command.Parameters.Add("@ordid", MySqlDbType.VarChar).Value = order_id;
            command.Parameters.Add("@invid", MySqlDbType.VarChar).Value = invent_id;
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = supplier_id;
            command.Parameters.Add("@qnty", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("@cst", MySqlDbType.Float).Value = total_coat;
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

        //update order

        public bool update_order(string order_id, string invent_id, int quantity, float total_coat)
        {
            MySqlCommand command = new MySqlCommand("UPDATE orders SET invent_id = @id,quantity = @qt,total_cost = @tc where order_id = @oid", connect.GetSqlConnection);
            command.Parameters.Add("@oid", MySqlDbType.VarChar).Value = order_id;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = invent_id;
            command.Parameters.Add("@qt", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("@tc", MySqlDbType.Float).Value = total_coat;

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
        public bool add_cart(string order_id, string invent_id, string supplier_id, int quantity, float total_coat)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `cart`(`order_id`,`invent_id`,`supplier_id`,`quantity`,`cost`)" +
                "VALUES (@ordid,@invid,@sid,@qnty,@cst)", connect.GetSqlConnection);
            command.Parameters.Add("@ordid", MySqlDbType.VarChar).Value = order_id;
            command.Parameters.Add("@invid", MySqlDbType.VarChar).Value = invent_id;
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = supplier_id;
            command.Parameters.Add("@qnty", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("@cst", MySqlDbType.Float).Value = total_coat;

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

        public bool truncate()
        {
            MySqlCommand command = new MySqlCommand("TRUNCATE TABLE cart", connect.GetSqlConnection);

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return false;
            }
            else
            {
                connect.closeConnect();
                return true;
            }
        }

        public bool delcart(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM cart WHERE id = @id", connect.GetSqlConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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

        public bool clear(string code)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM cart WHERE id = @code", connect.GetSqlConnection);

            command.Parameters.Add("@code", MySqlDbType.VarChar).Value = code;

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

        public bool deliver(string code, string state)
        {
            MySqlCommand command = new MySqlCommand("UPDATE orders SET state = @st WHERE order_id = @id", connect.GetSqlConnection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = code;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = state;


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
