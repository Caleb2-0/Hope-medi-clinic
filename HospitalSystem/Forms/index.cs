using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class index : Form
    {
        passwordchange pc = new passwordchange();
        appointments aps = new appointments();
        connection con = new connection();
        login log = new login();
        public index()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            control.exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            control.Minimize(this);
        }

        private void Maxbtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            control.DoMaximize(this, btn);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                textpass.UseSystemPasswordChar = false;
            }
            else
            {
                textpass.UseSystemPasswordChar = true;
            }
        }

        private void index_Load(object sender, EventArgs e)
        {
            textpass.UseSystemPasswordChar = true;
        }

        private void signin_Click(object sender, EventArgs e)
        {
            var username = textuser.Text;
            var password = textpass.Text;
            try
            {
                if (log.user_login(username, password))
                {
                    try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("select * from staffs where username = '" + username + "' and password = '" + password + "'", con.GetSqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            string pass = dt.Rows[0]["password"].ToString();
                            if (pass == "default")
                            {
                                passwordchange pc = new passwordchange();
                                pc.uname = textuser.Text;
                                pc.ShowDialog();
                            }
                            else
                            {
                                DateTime date = DateTime.Now.Date;
                                string staff_id = dt.Rows[0]["staff_id"].ToString();
                                string time = DateTime.Now.ToLongTimeString();
                                switch (dt.Rows[0]["role"] as string)
                                {
                                    case "Admin":
                                        {
                                            adminDashboard ad = new adminDashboard();
                                            log.login_log(staff_id, time, date);
                                            ad.staff_id = staff_id;
                                            ad.uname = textuser.Text;
                                            this.Hide();
                                            ad.Show();
                                        }
                                        break;
                                    case "Receiptionist":
                                        {
                                            recDashboard rd = new recDashboard();
                                            log.login_log(staff_id, time, date);
                                            rd.staff_id = staff_id;
                                            rd.uname = textuser.Text;
                                            this.Hide();
                                            rd.Show();
                                        }
                                        break;
                                    case "LabTech":
                                        {
                                            labDashboard ad = new labDashboard();
                                            log.login_log(staff_id, time, date);
                                            ad.staff_id = staff_id;
                                            ad.uname = textuser.Text;
                                            this.Hide();
                                            ad.Show();
                                        }
                                        break;
                                    case "Doctor":
                                        {
                                            docDashboard dd = new docDashboard();
                                            log.login_log(staff_id, time, date);
                                            dd.staff_id = staff_id;
                                            dd.uname = textuser.Text;
                                            this.Hide();
                                            dd.Show();
                                        }
                                        break;
                                    default:
                                        MessageBox.Show("User Role Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                }
                            }
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
                    label1.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                toolTip1.SetToolTip(button1, "Resore Down");
            }
        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {
            if (label1.Visible == true)
            {
                label1.Visible = false;
            }
        }
    }
}
