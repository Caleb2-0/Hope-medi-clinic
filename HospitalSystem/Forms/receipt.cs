using HospitalSystem.Classes;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class receipt : Form
    {
        transactions tr = new transactions();
        inventories iv = new inventories();
        appointments aps = new appointments();
        connection conn = new connection();
        public receipt()
        {
            InitializeComponent();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            ReportDataSource totalc = new ReportDataSource("total", total());
            ReportDataSource rec = new ReportDataSource("receipt", receipts());
            ReportDataSource ser = new ReportDataSource("services", services());
            reportViewer1.LocalReport.ReportPath = @"D:\L5DC\Assignments\HospitalSystem\HospitalSystem\receipt.rdlc";
            reportViewer1.LocalReport.DataSources.Add(totalc);
            reportViewer1.LocalReport.DataSources.Add(rec);
            reportViewer1.LocalReport.DataSources.Add(ser);
            reportViewer1.RefreshReport();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //to set the intial number of control variable

            string sql = "SELECT count(*) as count FROM receipt_temp where quantity is not null";
            string con = aps.getid(sql, "count");

            //to loop through the table while writtimg to db
            int counter = 0;
            int control = Int32.Parse(con);
            while (counter < control)
            {

                string ssql = "SELECT * FROM receipt_temp where quantity is not null limit 1";
                MySqlDataAdapter da1 = new MySqlDataAdapter(ssql, conn.GetSqlConnection);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {

                    string trans_id = dt1.Rows[0]["trans_id"].ToString();
                    string invent_id = dt1.Rows[0]["invent_id"].ToString();
                    string quantity = dt1.Rows[0]["quantity"].ToString();
                    string cost = dt1.Rows[0]["cost"].ToString();
                    float cost1 = float.Parse(cost);
                    DateTime date = DateTime.Now.Date;
                    string pre_id = dt1.Rows[0]["pre_id"].ToString();
                    string temp_id = dt1.Rows[0]["temp_id"].ToString();
                    string service_id = dt1.Rows[0]["service_id"].ToString();
                    int id = int.Parse(temp_id);

                    string sql1 = "SELECT * FROM inventory where invent_id = '" + invent_id + "' limit 1";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql1, conn.GetSqlConnection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        string stock = dt.Rows[0]["quantity"].ToString();
                        int num1 = int.Parse(stock);
                        int num2 = int.Parse(quantity);
                        int res = num1 - num2;

                        try
                        {
                            if (iv.updtQ(invent_id, res))
                            {
                                try
                                {
                                    if (tr.addTrans(trans_id, pre_id, service_id, cost1, date))
                                    {
                                        try
                                        {
                                            tr.delTrans(id);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Something Went Wrong While Adding Transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong While Subtracting Items From Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                conn.closeConnect();
                counter++;
                this.Close();

            }
            
        }                
        private DataTable total()
        {
            DataTable dt = new DataTable();
            conn.openConnect();
            MySqlCommand command = new MySqlCommand("SELECT SUM(cost)as total FROM receipt_temp", conn.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            conn.closeConnect();
            return dt;
        }
        private DataTable services()
        {
            DataTable dt = new DataTable();
            conn.openConnect();
            MySqlCommand command = new MySqlCommand("select s.s_name,r.cost from services s join receipt_temp r on s.service_id = r.service_id", conn.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            conn.closeConnect();
            return dt;
        }
        private DataTable receipts()
        {
            DataTable dt = new DataTable();
            conn.openConnect();
            MySqlCommand command = new MySqlCommand("select i.name AS ITEM,t.quantity AS QUANTITY,t.cost AS COST,t.date AS DATE,t.trans_id from inventory i join receipt_temp t where i.invent_id = t.invent_id AND name != 'Null'", conn.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            conn.closeConnect();
            return dt;
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            //to set the intial number of control variable

            string sql = "SELECT count(*) as count FROM receipt_temp where quantity is not null";
            string con = aps.getid(sql, "count");

            //to loop through the table while writtimg to db
            int counter = 0;
            int control = Int32.Parse(con);
            while (counter < control)
            {

                string ssql = "SELECT * FROM receipt_temp where quantity is not null limit 1";
                MySqlDataAdapter da1 = new MySqlDataAdapter(ssql, conn.GetSqlConnection);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {

                    string trans_id = dt1.Rows[0]["trans_id"].ToString();
                    string invent_id = dt1.Rows[0]["invent_id"].ToString();
                    string quantity = dt1.Rows[0]["quantity"].ToString();
                    string cost = dt1.Rows[0]["cost"].ToString();
                    float cost1 = float.Parse(cost);
                    DateTime date = DateTime.Now.Date;
                    string pre_id = dt1.Rows[0]["pre_id"].ToString();
                    string temp_id = dt1.Rows[0]["temp_id"].ToString();
                    string service_id = dt1.Rows[0]["service_id"].ToString();
                    int id = int.Parse(temp_id);

                    string sql1 = "SELECT * FROM inventory where invent_id = '" + invent_id + "' limit 1";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql1, conn.GetSqlConnection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        string stock = dt.Rows[0]["quantity"].ToString();
                        int num1 = int.Parse(stock);
                        int num2 = int.Parse(quantity);
                        int res = num1 - num2;

                        try
                        {
                            if (iv.updtQ(invent_id, res))
                            {
                                try
                                {
                                    if (tr.addTrans(trans_id, pre_id, service_id, cost1, date))
                                    {
                                        try
                                        {
                                            tr.delTrans(id);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Something Went Wrong While Adding Transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong While Subtracting Items From Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                conn.closeConnect();
                counter++;
                this.Close();

            }
        }
    }
}
