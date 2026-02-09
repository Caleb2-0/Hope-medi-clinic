using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class prescribe : Form
    {
        public string diagonosisid { set; get; }
        appointments aps = new appointments();
        staffs sf = new staffs();
        prescriptions ps = new prescriptions();
        connection con = new connection();
        public prescribe()
        {
            InitializeComponent();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Close This Window? This Can Not Be Undone", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int cont = int.Parse(aps.getid("SELECT COUNT(*) as control FROM prescriptions_temp", "control"));
                int counter = 0;

                while (counter < cont)
                {
                    string sql = "SELECT * FROM prescriptions_temp LIMIT 1";
                    MySqlDataAdapter ad = new MySqlDataAdapter(sql, con.GetSqlConnection);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        int id = int.Parse(dt.Rows[0]["id"].ToString());
                        int quantity = int.Parse(dt.Rows[0]["quantity"].ToString());
                        string dig_id = dt.Rows[0]["diagonosis_id"].ToString();
                        DateTime date = DateTime.Now.Date;
                        string invent_id = dt.Rows[0]["invent_id"].ToString();
                        string pre_id = dt.Rows[0]["pre_id"].ToString();
                        try
                        {
                            if (ps.addpres(pre_id,dig_id, invent_id, quantity, date))
                            {
                                try
                                {
                                    if (ps.removp(id))
                                    {

                                    }
                                    else
                                    {
                                        MessageBox.Show("Items Coundn't Be Removed From Temp Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                MessageBox.Show("Coudn't Add Items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                    counter++;
                }
                con.closeConnect();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void prescribe_Load(object sender, EventArgs e)
        {
            label5.Text = "PPES: " + staffs.userid();
            label2.Text = diagonosisid;
            viewp();
            fillcombo();
        }

        public void viewp()
        {
            dataGridView1.DataSource = sf.view_db_records(new MySqlCommand("SELECT i.name AS ITEM,p.quantity AS QUANTITY FROM inventory i JOIN prescriptions_temp p WHERE i.invent_id = p.invent_id"));
        }
        private void fillcombo()
        {
            string query = "SELECT name FROM inventory where name != 'Null'";
            string display = "name";
            appointments.populatecombo(comboitm, query, display);
        }

        private void comboitm_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = aps.getid("select * from inventory where name = '" + comboitm.Text + "'", "invent_id");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            string invent_id = label1.Text;
            int quantity = int.Parse(bunifuCustomTextbox1.Text);
            string dig_id = label2.Text;
            DateTime date = DateTime.Now.Date;
            string pre_id = label5.Text;

            if (comboitm.Text == "" || bunifuCustomTextbox1.Text == "")
            {
                MessageBox.Show("Please Fill All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (ps.addpresT(pre_id,dig_id, invent_id, quantity, date))
                    {
                        bunifuCustomTextbox1.Clear();
                        viewp();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label4.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            int id = int.Parse(label4.Text);
            if (label4.Text == "label4")
            {
                MessageBox.Show("Please Choose An Item To Remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (ps.removp(id))
                    {
                        viewp();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
