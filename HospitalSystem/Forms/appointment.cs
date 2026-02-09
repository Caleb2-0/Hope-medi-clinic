using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;




namespace HospitalSystem.Forms
{
    public partial class appointment : Form
    {
        private const string Host = "smtp.gmail.com";

        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recBut4;
        private Rectangle recBut5;
        private Rectangle recBut6;
        private Rectangle recBut7;
        private Rectangle recBut8;
        private Rectangle recBut9;
        private Rectangle recBut10;
        private Rectangle recBut11;
        private Rectangle recBut12;
        private Rectangle recBut13;
        private Rectangle recBut14;
        private Rectangle recBut15;
        private Rectangle recBut16;
        private Rectangle recBut17;
        private Rectangle recBut18;
        private Rectangle recBut19;
        private Rectangle recBut20;
        private Rectangle recBut21;
        private Rectangle recBut22;
        private Rectangle recBut23;
        private Rectangle recBut24;
        private Rectangle recBut25;

        appointments appointments = new appointments();
        connection connect = new connection();
        staffs sf = new staffs();
        public appointment()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(guna2GroupBox1.Location, guna2GroupBox1.Size);
            recBut2 = new Rectangle(btnAdd.Location, btnAdd.Size);
            recBut3 = new Rectangle(btnUPDT.Location, btnUPDT.Size);
            recBut4 = new Rectangle(btnCOMP.Location, btnCOMP.Size);
            recBut5 = new Rectangle(btnCancel.Location, btnCancel.Size);
            recBut6 = new Rectangle(comboFname.Location, comboFname.Size);
            recBut7 = new Rectangle(comboLname.Location, comboLname.Size);
            recBut8 = new Rectangle(comboDname.Location, comboDname.Size);
            recBut9 = new Rectangle(Adtp.Location, Adtp.Size);
            recBut10 = new Rectangle(Adtp1.Location, Adtp1.Size);
            recBut11 = new Rectangle(btnRes.Location, btnRes.Size);
            recBut12 = new Rectangle(btnGo.Location, btnGo.Size);
            recBut13 = new Rectangle(gunaLabel1.Location, gunaLabel1.Size);
            recBut14 = new Rectangle(gunaLabel2.Location, gunaLabel2.Size);
            recBut15 = new Rectangle(gunaLabel3.Location, gunaLabel3.Size);
            recBut16 = new Rectangle(gunaLabel4.Location, gunaLabel4.Size);
            recBut17 = new Rectangle(gunaLabel5.Location, gunaLabel5.Size);
            recBut18 = new Rectangle(gunaLabel6.Location, gunaLabel6.Size);
            recBut19 = new Rectangle(gunaLabel7.Location, gunaLabel7.Size);
            recBut20 = new Rectangle(gunaLabel8.Location, gunaLabel8.Size);
            recBut21 = new Rectangle(gunaLabel9.Location, gunaLabel9.Size);
            recBut22 = new Rectangle(dgv.Location, dgv.Size);
            recBut23 = new Rectangle(comboBox1.Location, comboBox1.Size);
            recBut24 = new Rectangle(guna2ComboBox1.Location, guna2ComboBox1.Size);
            recBut25 = new Rectangle(gunaLabel10.Location, gunaLabel10.Size);

        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(guna2GroupBox1, recBut1);
            resize_Control(btnAdd, recBut2);
            resize_Control(btnUPDT, recBut3);
            resize_Control(btnCOMP, recBut4);
            resize_Control(btnCancel, recBut5);
            resize_Control(comboFname, recBut6);
            resize_Control(comboLname, recBut7);
            resize_Control(comboDname, recBut8);
            resize_Control(Adtp, recBut9);
            resize_Control(Adtp1, recBut10);
            resize_Control(btnRes, recBut11);
            resize_Control(btnGo, recBut12);
            resize_Control(gunaLabel1, recBut13);
            resize_Control(gunaLabel2, recBut14);
            resize_Control(gunaLabel3, recBut15);
            resize_Control(gunaLabel4, recBut16);
            resize_Control(gunaLabel5, recBut17);
            resize_Control(gunaLabel6, recBut18);
            resize_Control(gunaLabel7, recBut19);
            resize_Control(gunaLabel8, recBut20);
            resize_Control(gunaLabel9, recBut21);
            resize_Control(dgv, recBut22);
            resize_Control(comboBox1, recBut23);
            resize_Control(guna2ComboBox1, recBut24);
            resize_Control(gunaLabel10, recBut25);


        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private void appointment_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillcombo1();
            fillcombo2();
            viewacc();
            Adtp.Value = DateTime.Now.Date;
        }

        private void fillcombo()
        {
            string query = "SELECT first_name FROM clients";
            string display = "first_name";
            appointments.populatecombo(comboFname, query, display);
        }

        private void fillcombo1()
        {
            string query = "SELECT last_name FROM clients";
            string display = "last_name";
            appointments.populatecombo(comboLname, query, display);
        }

        private void fillcombo2()
        {
            string role = "Doctor";
            string query = "SELECT first_name FROM staffs where role = '"+role+"'";
            string display = "first_name";
            appointments.populatecombo(comboDname, query, display);
        }
        private void viewacc()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("select a.app_id as ID,c.first_name as FIRSTNAME,c.last_name as LASTNAME,s.first_name as DOCTOR, a.date as DATE,a.time as TIME,a.state as STATE from clients c, staffs s, appointments a where c.client_id = a.client_id AND s.staff_id = a.staff_id AND a.date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'"));
        }
        private void viewacc1()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("select a.app_id as ID,c.first_name as FIRSTNAME,c.last_name as LASTNAME,s.first_name as DOCTOR, a.date as DATE,a.time as TIME,a.state as STATE from clients c, staffs s, appointments a where c.client_id = a.client_id AND s.staff_id = a.staff_id AND a.date = '" + Adtp1.Value.ToString("yyyy-MM-dd") + "'"));
        }
        private void viewacc2()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("select a.app_id as ID,c.first_name as FIRSTNAME,c.last_name as LASTNAME,s.first_name as DOCTOR, a.date as DATE,a.time as TIME,a.state as STATE from clients c, staffs s, appointments a where c.client_id = a.client_id AND s.staff_id = a.staff_id AND a.state = '" + comboBox1.Text + "' AND a.date = '" + Adtp1.Value.ToString("yyyy-MM-dd") + "'"));
        }
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query_c = "SELECT * FROM clients where first_name = '" + comboFname.Text + "' AND last_name = '" + comboLname.Text + "'";
            string query_s = "SELECT * FROM staffs where first_name = '" + comboDname.Text + "' AND role = 'Doctor' Limit 1";
            string id = "email";
            string fn = "first_name";
            string ln = "last_name";
            string dn = "last_name";
            string client_email = appointments.getid(query_c, id);
            string client_message = "Dear " + appointments.getid(query_c, fn) + " " + appointments.getid(query_c, ln) + ", You have an appointment on " + Adtp1.Value.ToString("yyyy-mm-dd") + ", at " + guna2ComboBox1.Text + " with Dr." + appointments.getid(query_s, dn) + ", Thank you.";
            string staff_message = "Hello Dr." + appointments.getid(query_s, ln) + " you have an appointment on " + Adtp1.Value.ToString("yyyy-mm-dd") + " at " + guna2ComboBox1.Text + " with " + appointments.getid(query_c, fn) + "" + appointments.getid(query_c, ln) + ", Thanks.";
            string staff_email = appointments.getid(query_s, id);
            string subject = "Appointment";
            TimeSpan.TryParse(guna2ComboBox1.Text, out TimeSpan ti);
            string con = DateTime.Now.ToString();
            string con1 = Adtp.Value.ToString();
            string query = "select client_id from clients where first_name = '" + comboFname.Text + "' and last_name = '" + comboLname.Text + "'";
            string query2 = "select staff_id from staffs where first_name = '" + comboDname.Text + "'";
            string dis = "client_id";
            string dis2 = "staff_id";
            DateTime date = Adtp.Value.Date;

            if (comboFname.Text == "" || comboLname.Text == "" || comboDname.Text == "" || guna2ComboBox1.Text == "")
            {
                MessageBox.Show("Please Select all Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (con == con1)
            {
                MessageBox.Show("Please Choose A correct date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string cid = appointments.getid(query, dis);
                string sid = appointments.getid(query2, dis2);
                DateTime dt = Adtp.Value.Date;
                TimeSpan.TryParse(guna2ComboBox1.Text, out TimeSpan time);
                string state = "Active";
                string aid = "APMT:" + staffs.userid();

                try
                {
                    if (appointments.Check(dt, sid, time))
                    {
                        MessageBox.Show("Conflicting Time, Please Choose Another Time");
                        return;
                    }
                    else
                    {
                        try
                        {
                            if (appointments.addApp(aid, sid, cid, dt, time, state))
                            {
                                MessageBox.Show("Appointment Record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                appointments.sendmail(client_email, subject, client_message);
                                appointments.sms(client_message);
                                appointments.sendmail(staff_email, subject, staff_message);
                                appointments.sms(staff_message);
                                viewacc();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong,Try Again");
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error" + ex);
                            return;
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                    return;
                }
            }
        }
        private void btnUPDT_Click(object sender, EventArgs e)
        {
            string dis = "client_id";
            string dis2 = "staff_id";
            string query = "select client_id from clients where first_name = '" + comboFname.Text + "' and last_name = '" + comboLname.Text + "'";
            string query2 = "select staff_id from staffs where first_name = '" + comboDname.Text + "'";
            string cid = appointments.getid(query, dis);
            string sid = appointments.getid(query2, dis2);
            DateTime dt = Adtp.Value.Date;
            TimeSpan.TryParse(guna2ComboBox1.Text, out TimeSpan time);
            string state = "Active";
            string app_id = label1.Text;

            try
            {
                if (appointments.update(app_id, sid, cid, dt, time, state))
                {
                    MessageBox.Show("Appointment Ameded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viewacc();
                    return;
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                return;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                comboFname.Text = row.Cells[1].Value.ToString();
                comboLname.Text = row.Cells[2].Value.ToString();
                comboDname.Text = row.Cells[3].Value.ToString();
                guna2ComboBox1.Text = row.Cells[5].Value.ToString();
                Adtp.Text = row.Cells[4].Value.ToString();
                label1.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnCOMP_Click(object sender, EventArgs e)
        {
            string app_id = label1.Text;
            string updt = "Completed";
            try
            {
                if (appointments.res(app_id, updt))
                {
                    MessageBox.Show("Appointment Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viewacc();
                    return;
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Cancel This Appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string app_id = label1.Text;
                string updt = "Cancelled";
                try
                {
                    if (appointments.res(app_id, updt))
                    {
                        MessageBox.Show("Appointment Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewacc();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                    return;
                }
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            viewacc();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                viewacc1();
            }
            else
            {
                viewacc2();
            }
        }
    }
}