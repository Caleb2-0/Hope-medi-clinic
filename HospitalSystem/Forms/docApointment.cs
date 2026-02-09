using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class docApointment : Form
    {
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

        staffs sf = new staffs();
        diagonosis dg = new diagonosis();
        public docApointment()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(txtFN.Location, txtFN.Size);
            recBut2 = new Rectangle(txtLN.Location, txtLN.Size);
            recBut3 = new Rectangle(txtSP.Location, txtSP.Size);
            recBut4 = new Rectangle(txtT.Location, txtT.Size);
            recBut5 = new Rectangle(txtD.Location, txtD.Size);
            recBut7 = new Rectangle(btnL.Location, btnL.Size);
            recBut8 = new Rectangle(btnP.Location, btnP.Size);
            recBut9 = new Rectangle(btnF.Location, btnF.Size);
            recBut10 = new Rectangle(btnR.Location, btnR.Size);
            recBut11 = new Rectangle(btnG.Location, btnG.Size);
            recBut12 = new Rectangle(comboFname.Location, comboFname.Size);
            recBut13 = new Rectangle(dgv.Location, dgv.Size);
            recBut14 = new Rectangle(gunaLabel1.Location, gunaLabel1.Size);
            recBut15 = new Rectangle(gunaLabel2.Location, gunaLabel2.Size);
            recBut16 = new Rectangle(gunaLabel3.Location, gunaLabel3.Size);
            recBut17 = new Rectangle(gunaLabel4.Location, gunaLabel4.Size);
            recBut18 = new Rectangle(gunaLabel5.Location, gunaLabel5.Size);
            recBut19 = new Rectangle(gunaLabel6.Location, gunaLabel6.Size);
            recBut20 = new Rectangle(gunaLabel7.Location, gunaLabel7.Size);
            recBut22 = new Rectangle(guna2GroupBox1.Location, guna2GroupBox1.Size);
            recBut23 = new Rectangle(btnD.Location, btnD.Size);
        }
        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(txtFN, recBut1);
            resize_Control(txtLN, recBut2);
            resize_Control(txtSP, recBut3);
            resize_Control(txtT, recBut4);
            resize_Control(txtD, recBut5);
            resize_Control(btnL, recBut7);
            resize_Control(btnP, recBut8);
            resize_Control(btnF, recBut9);
            resize_Control(btnR, recBut10);
            resize_Control(btnG, recBut11);
            resize_Control(comboFname, recBut12);
            resize_Control(dgv, recBut13);
            resize_Control(gunaLabel1, recBut14);
            resize_Control(gunaLabel2, recBut15);
            resize_Control(gunaLabel3, recBut16);
            resize_Control(gunaLabel4, recBut17);
            resize_Control(gunaLabel5, recBut18);
            resize_Control(gunaLabel6, recBut19);
            resize_Control(gunaLabel7, recBut20);
            resize_Control(guna2GroupBox1, recBut22);
            resize_Control(btnD, recBut23);

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

        private void btnP_Click(object sender, EventArgs e)
        {
            label1.Text = "DGN-" + staffs.userid();
            prescribe ps = new prescribe();
            ps.diagonosisid = label2.Text;
            ps.ShowDialog();
        }

        private void docApointment_Load(object sender, EventArgs e)
        {
            label3.Text = "App";
            viewapp();
        }
        public void viewapp()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT a.app_id AS ID,c.first_name AS FIRSTNAME,c.last_name AS LASTNAME,c.age AS CLIENT_AGE,a.date AS DATE,a.time as TIME FROM appointments a,clients c WHERE a.client_id = c.client_id AND state = 'Active'"));
        }
        public void filterapp()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT * FROM(SELECT a.app_id AS ID,c.first_name AS FIRSTNAME,c.last_name AS LASTNAME,c.age AS CLIENT_AGE,a.date AS DATE,a.time as TIME,a.state as STATE FROM appointments a,clients c WHERE a.client_id = c.client_id) as res WHERE STATE = '" + comboFname.Text + "'"));
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && label3.Text == "App")
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label2.Text = row.Cells[0].Value.ToString();
                txtFN.Text = row.Cells[1].Value.ToString();
                txtLN.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                DataGridViewRow rows = this.dgv.Rows[e.RowIndex];
                label2.Text = rows.Cells[0].Value.ToString();
                txtFN.Text = rows.Cells[1].Value.ToString();
                txtLN.Text = rows.Cells[2].Value.ToString();
                txtSP.Text = rows.Cells[3].Value.ToString();
                txtT.Text = rows.Cells[4].Value.ToString();
                txtD.Text = rows.Cells[5].Value.ToString();
                label4.Text = rows.Cells[4].Value.ToString();
            }
        }

        private void viewD()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT * FROM(SELECT d.diagonosis_id AS ID,c.first_name AS FIRTSNAME,c.last_name AS LASTNAME,d.symptoms AS SYMPTOMS,d.test AS TEST,d.result AS RESULT,d.date AS DATE FROM clients c,appointments a JOIN diagonosis d WHERE c.client_id = a.client_id AND a.app_id = d.app_id) AS result"));
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label3.Text = "dia";
            gunaLabel6.Text = "All Diagonisis";
            viewD();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            label3.Text = "App";
            gunaLabel6.Text = "All Appointments";
            viewapp();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            string app_id = label2.Text;
            string dia_id = "DGNS:" + staffs.userid();
            string symp = txtSP.Text;
            string test = txtT.Text;
            DateTime date = DateTime.Now.Date;
            DateTime adate = date.Date;

            if (txtSP.Text == "" || txtT.Text == "" || txtFN.Text == "" || txtLN.Text == "")
            {
                MessageBox.Show("Please Fill In All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (dg.addD(dia_id, app_id, symp, test, adate))
                    {
                        MessageBox.Show("Sent To Lab Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnF_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Clomplete The Appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string id = label2.Text;
                string state = "Completed";
                appointments aps = new appointments();
                try
                {
                    if (aps.res(id, state))
                    {
                        MessageBox.Show("Appointment Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewapp();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong,Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return;
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            filterapp();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnL_Click_1(object sender, EventArgs e)
        {
            string app_id = label2.Text;
            string dia_id = "DGNS:" + staffs.userid();
            string symp = txtSP.Text;
            string test = txtT.Text;
            DateTime date = DateTime.Now.Date;
            DateTime adate = date.Date;

            if (txtSP.Text == "" || txtT.Text == "" || txtFN.Text == "" || txtLN.Text == "")
            {
                MessageBox.Show("Please Fill In All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (dg.addD(dia_id, app_id, symp, test, adate))
                    {
                        MessageBox.Show("Sent To Lab Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnP_Click_1(object sender, EventArgs e)
        {
            label1.Text = "DGN-" + staffs.userid();
            prescribe ps = new prescribe();
            ps.diagonosisid = label2.Text;
            ps.ShowDialog();
        }

        private void btnF_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Clomplete The Appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string id = label2.Text;
                string state = "Completed";
                appointments aps = new appointments();
                try
                {
                    if (aps.res(id, state))
                    {
                        MessageBox.Show("Appointment Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewapp();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong,Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            label3.Text = "App";
            gunaLabel6.Text = "All Appointments";
            viewapp();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && label3.Text == "App")
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label2.Text = row.Cells[0].Value.ToString();
                txtFN.Text = row.Cells[1].Value.ToString();
                txtLN.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                DataGridViewRow rows = this.dgv.Rows[e.RowIndex];
                label2.Text = rows.Cells[0].Value.ToString();
                txtFN.Text = rows.Cells[1].Value.ToString();
                txtLN.Text = rows.Cells[2].Value.ToString();
                txtSP.Text = rows.Cells[3].Value.ToString();
                txtT.Text = rows.Cells[4].Value.ToString();
                txtD.Text = rows.Cells[5].Value.ToString();
                label4.Text = rows.Cells[4].Value.ToString();
            }
        }

        private void btnD_Click_1(object sender, EventArgs e)
        {
            label3.Text = "dia";
            gunaLabel6.Text = "All Diagonisis";
            viewD();
        }
    }
}
