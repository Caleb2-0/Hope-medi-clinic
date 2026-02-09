using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace HospitalSystem.Forms
{
    public partial class cart : Form
    {
        public string email { set; get; }
        staffs sf = new staffs();
        orders or = new orders();
        appointments aps = new appointments();
        connection con = new connection();
        public cart()
        {
            InitializeComponent();
        }

        private void cart_Load(object sender, EventArgs e)
        {
            label4.Text = email;
            label3.Text = aps.getid("SELECT * FROM cart LIMIT 1", "order_id");
            viewcart();
        }
        private void viewcart()
        {
            guna2DataGridView1.DataSource = sf.view_db_records(new MySqlCommand("select o.id,o.order_id as ID,i.name as NAME,s.name as SUPPLIERNAME,o.quantity as QUANTITY,o.cost as TOTALCOST from inventory i, cart o, suppliers s where o.invent_id = i.invent_id AND s.supplier_id = o.supplier_id"));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want Close? All Unsaved Changes Will Be Lost", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (or.truncate())
                {
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
        private void btnCan_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Cancel The Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (or.truncate())
                {
                    MessageBox.Show("Order Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                return;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
                label1.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "label1")
            {
                MessageBox.Show("Please Select an Item To Remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int id = int.Parse(label1.Text);
                try
                {
                    if (or.delcart(id))
                    {
                        MessageBox.Show("Item Removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewcart();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("SOmething Went Wrong,Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            //to set the intial number of control variable

            string sql = "SELECT count(*) as count FROM cart";
            string query = "select ORDERID, group_concat( name separator ', ')as result from (select ORDERID, concat(NAME,' ',QUANTITY) as name from(select o.id,o.order_id as ORDERID,i.name as NAME,s.name as SUPPLIERNAME,o.quantity as QUANTITY,o.cost as TOTALCOST from inventory i, cart o, suppliers s where o.invent_id = i.invent_id AND s.supplier_id = o.supplier_id AND o.order_id = '" + label3.Text + "') as result) as result order by ORDERID;\r\n";
            label1.Text = aps.getid(sql, "count");
            label2.Text = aps.getid(query, "result");
            string message = "Hello, We Would Like to Make an Order of the following items with their quantities: " + label2.Text +".  Thank you.";
            
            try
            {
                if(aps.sendmail(label4.Text, "Order", message))
                {
                    int counter = 0;
                    int control = Int32.Parse(label1.Text);

                    try
                    {
                        while (counter < control)
                        {

                            MySqlCommand cmm;
                            MySqlDataReader drr;
                            string ssql = "SELECT * FROM cart limit 1";
                            cmm = new MySqlCommand(ssql, con.GetSqlConnection);
                            con.openConnect();
                            drr = cmm.ExecuteReader();

                            while (drr.Read())
                            {
                                string order_id = drr["order_id"].ToString();
                                string invent_id = drr["invent_id"].ToString();
                                string supplier_id = drr["supplier_id"].ToString();
                                string q = drr["quantity"].ToString();
                                int quantity = int.Parse(q);
                                string c = drr["cost"].ToString();
                                float cost = float.Parse(c);
                                DateTime date = DateTime.Now;
                                string code = drr["id"].ToString();


                                try
                                {
                                    if (or.add_order(order_id, invent_id, supplier_id, quantity, cost, date))
                                    {
                                        try
                                        {
                                            or.clear(code);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show("Order Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            con.closeConnect();
                            counter++;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Something Went Wrong,Please Check internet connection and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Order Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
