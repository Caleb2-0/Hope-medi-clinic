using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class labDashboard : Form
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
        int seconds = 6;
        public string uname { set; get; }
        public string staff_id { get; set; }
        public static labDashboard instance;
        public Label plb;
        login log = new login();
        staffs sf = new staffs();
        diagonosis dg = new diagonosis();
        public labDashboard()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(btnD.Location, btnD.Size);
            recBut2 = new Rectangle(btnS.Location, btnS.Size);
            recBut3 = new Rectangle(panelFill.Location, panelFill.Size);
            recBut4 = new Rectangle(panel2.Location, panel2.Size);
            recBut5 = new Rectangle(comboFname.Location, comboFname.Size);
            recBut6 = new Rectangle(bunifuCustomLabel1.Location, bunifuCustomLabel1.Size);
            recBut7 = new Rectangle(btnRES.Location, btnRES.Size);
            recBut8 = new Rectangle(dtp.Location, dtp.Size);
            instance = this;
            plb = label3;
        }
        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnD, recBut1);
            resize_Control(btnS, recBut2);
            resize_Control(panelFill, recBut3);
            resize_Control(panel2, recBut4);
            resize_Control(comboFname, recBut5);
            resize_Control(bunifuCustomLabel1, recBut6);
            resize_Control(btnRES, recBut7);
            resize_Control(dtp, recBut8);
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

        private void viewD()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT d.diagonosis_id AS ID,c.first_name AS FIRTSNAME,c.last_name AS LASTNAME,d.symptoms AS SYMPTOMS,d.test AS TEST,d.result AS RESULT,d.date AS DATE FROM clients c,appointments a JOIN diagonosis d WHERE c.client_id = a.client_id AND a.app_id = d.app_id AND result IS NULL"));
        }

        private void filterD()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT * FROM (SELECT d.diagonosis_id AS ID,c.first_name AS FIRTSNAME,c.last_name AS LASTNAME,d.symptoms AS SYMPTOMS,d.test AS TEST,d.result AS RESULT,d.date AS DATE FROM clients c,appointments a JOIN diagonosis d WHERE c.client_id = a.client_id AND a.app_id = d.app_id) AS result WHERE DATE = '" + dtp.Value.ToString("yyyy-MM-dd") + "'"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            control.DoMaximize(this, btn);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            control.Minimize(this);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Sign Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string time = DateTime.Now.ToLongTimeString();
                string staff_id = label3.Text;
                DateTime date = DateTime.Now.Date;
                log.logout_log(staff_id, time, date);
                index ind = new index();
                this.Close();
                ind.Show();
            }
            else
            {
                return;
            }
        }

        private void labDashboard_Load(object sender, EventArgs e)
        {
            label4.Text = uname;
            viewD();
            label3.Text = staff_id;
            //showform(new cover());
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            filterD();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label2.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (comboFname.Text == "")
            {
                MessageBox.Show("Please Choose Diagonosis Result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string result = comboFname.Text;
                string diag_id = label2.Text;
                try
                {
                    if (dg.updt(diag_id, result))
                    {
                        MessageBox.Show("Result Sent Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewD();
                        comboFname.SelectedIndex = 0;
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

        private void btnRES_Click(object sender, EventArgs e)
        {
            viewD();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            passwordchange pc = new passwordchange();
            pc.uname = label4.Text;
            pc.ShowDialog();
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds = seconds - 1;
                label1.Text = seconds + "";

            }
            if (label1.Text == "0")
            {
                seconds = 6;
                viewD();

            }
        }
    }
}
