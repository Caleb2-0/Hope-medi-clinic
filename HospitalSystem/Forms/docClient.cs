using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class docClient : Form
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
        public string id { set; get; }
        staffs sf = new staffs();
        clients cl = new clients();
        public docClient()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(btnD.Location, btnD.Size);
            recBut2 = new Rectangle(btnU.Location, btnU.Size);
            recBut3 = new Rectangle(btnV.Location, btnV.Size);
            recBut4 = new Rectangle(txtFN.Location, txtFN.Size);
            recBut5 = new Rectangle(txtP.Location, txtP.Size);
            recBut6 = new Rectangle(bunifuCustomTextbox1.Location, bunifuCustomTextbox1.Size);
            recBut7 = new Rectangle(bunifuCustomTextbox2.Location, bunifuCustomTextbox2.Size);
            recBut8 = new Rectangle(bunifuCustomTextbox3.Location, bunifuCustomTextbox3.Size);
            recBut9 = new Rectangle(bunifuCustomTextbox4.Location, bunifuCustomTextbox4.Size);
            recBut10 = new Rectangle(bunifuCustomTextbox5.Location, bunifuCustomTextbox5.Size);
            recBut11 = new Rectangle(gunaLabel1.Location, gunaLabel1.Size);
            recBut12 = new Rectangle(gunaLabel2.Location, gunaLabel2.Size);
            recBut13 = new Rectangle(gunaLabel3.Location, gunaLabel3.Size);
            recBut14 = new Rectangle(gunaLabel4.Location, gunaLabel4.Size);
            recBut15 = new Rectangle(gunaLabel5.Location, gunaLabel5.Size);
            recBut16 = new Rectangle(gunaLabel6.Location, gunaLabel6.Size);
            recBut17 = new Rectangle(gunaLabel7.Location, gunaLabel7.Size);
            recBut18 = new Rectangle(dgv.Location, dgv.Size);
            recBut19 = new Rectangle(panel1.Location, panel1.Size);
        }
        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnD, recBut1);
            resize_Control(btnU, recBut2);
            resize_Control(btnV, recBut3);
            resize_Control(txtFN, recBut4);
            resize_Control(txtP, recBut5);
            resize_Control(bunifuCustomTextbox1, recBut6);
            resize_Control(bunifuCustomTextbox2, recBut7);
            resize_Control(bunifuCustomTextbox3, recBut8);
            resize_Control(bunifuCustomTextbox4, recBut9);
            resize_Control(bunifuCustomTextbox5, recBut10);
            resize_Control(gunaLabel1, recBut11);
            resize_Control(gunaLabel2, recBut12);
            resize_Control(gunaLabel3, recBut13);
            resize_Control(gunaLabel4, recBut14);
            resize_Control(gunaLabel5, recBut15);
            resize_Control(gunaLabel6, recBut16);
            resize_Control(gunaLabel7, recBut17);
            resize_Control(dgv, recBut18);
            resize_Control(panel1, recBut19);
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

        private void docClient_Load(object sender, EventArgs e)
        {
            viewac();
            label2.Text = id;
        }
        public void viewac()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT client_id AS ID,first_name AS FIRSTNAME,last_name AS LASTNAME,gender AS GENDER,date_of_birth AS DATE_OF_BIRTH,age AS AGE,address as ADDRESS,past_conditions AS PAST_CONITIONS FROM clients"));
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label1.Text = row.Cells[0].Value.ToString();
                txtFN.Text = row.Cells[1].Value.ToString();
                bunifuCustomTextbox1.Text = row.Cells[2].Value.ToString();
                bunifuCustomTextbox2.Text = row.Cells[3].Value.ToString();
                bunifuCustomTextbox3.Text = row.Cells[4].Value.ToString();
                bunifuCustomTextbox4.Text = row.Cells[5].Value.ToString();
                bunifuCustomTextbox5.Text = row.Cells[6].Value.ToString();
                txtP.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (txtFN.Text == "")
            {
                MessageBox.Show("Please Choose A Record To View", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                epass ep = new epass();
                ep.client_id = label1.Text;
                ep.ShowDialog();
            }

        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (txtFN.Text == "")
            {
                MessageBox.Show("Please Select A Client To Update Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtP.Text == "")
            {
                MessageBox.Show("Please Enter Information To Update With", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string client_id = label1.Text;
                string cond = txtP.Text;
                try
                {
                    if (cl.updtP(client_id, cond))
                    {
                        MessageBox.Show("Record Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewac();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Procced To Diagonose Without Appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                dWa da = new dWa();
                da.id = label2.Text;
                da.name = txtFN.Text;
                da.lname = bunifuCustomTextbox1.Text;
                da.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}
