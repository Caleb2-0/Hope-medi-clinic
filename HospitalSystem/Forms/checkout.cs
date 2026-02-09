using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace HospitalSystem.Forms
{
    public partial class checkout : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recBut5;
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
        int seconds = 6;
        appointments aps = new appointments();
        transactions tr = new transactions();
        staffs sf = new staffs();
        public checkout()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(dgvr.Location, dgvr.Size);
            recBut2 = new Rectangle(btnAdd.Location, btnAdd.Size);
            recBut3 = new Rectangle(dgvp.Location, dgvp.Size);
            recBut5 = new Rectangle(comboItm.Location, comboItm.Size);
            recBut9 = new Rectangle(bunifuCustomLabel4.Location, bunifuCustomLabel4.Size);
            recBut10 = new Rectangle(panel1.Location, panel1.Size);
            recBut11 = new Rectangle(guna2GroupBox1.Location, guna2GroupBox1.Size);
            recBut12 = new Rectangle(bunifuTextBox1.Location, bunifuTextBox1.Size);
            recBut13 = new Rectangle(bunifuTextBox2.Location, bunifuTextBox2.Size);
            recBut14 = new Rectangle(bunifuTextBox3.Location, bunifuTextBox3.Size);
            recBut15 = new Rectangle(bunifuCustomLabel4.Location, bunifuCustomLabel4.Size);
            recBut16 = new Rectangle(bunifuCustomLabel5.Location, bunifuCustomLabel5.Size);
            recBut17 = new Rectangle(bunifuCustomLabel6.Location, bunifuCustomLabel6.Size);
            recBut18 = new Rectangle(bunifuCustomLabel8.Location, bunifuCustomLabel8.Size);
            recBut19 = new Rectangle(bunifuCustomLabel9.Location, bunifuCustomLabel9.Size);
            recBut20 = new Rectangle(bunifuTextBox4.Location, bunifuTextBox4.Size);

        }
        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(dgvr, recBut1);
            resize_Control(btnAdd, recBut2);
            resize_Control(dgvp, recBut3);
            resize_Control(comboItm, recBut5);
            resize_Control(bunifuCustomLabel4, recBut9);
            resize_Control(panel1, recBut10);
            resize_Control(guna2GroupBox1, recBut11);
            resize_Control(bunifuTextBox1, recBut12);
            resize_Control(bunifuTextBox2, recBut13);
            resize_Control(bunifuTextBox3, recBut14);
            resize_Control(bunifuCustomLabel4, recBut15);
            resize_Control(bunifuCustomLabel5, recBut16);
            resize_Control(bunifuCustomLabel6, recBut17);
            resize_Control(bunifuCustomLabel8, recBut18);
            resize_Control(bunifuCustomLabel9, recBut19);
            resize_Control(bunifuTextBox4, recBut20);
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

        private void checkout_Load(object sender, EventArgs e)
        {
           // bunifuCustomLabel3.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
            bunifuCustomLabel12.Text = "TRANS:" + staffs.userid();
            veiwp();
            fillcomb();
            viewr();
            fillcomb2();
        }

        private void veiwp()
        {
            dgvp.DataSource = sf.view_db_records(new MySqlCommand("select pre_id AS ID, date as DATE,CLIENT_NAME, group_concat(name,' ',quantity) as result from(select p.pre_id, c.first_name AS CLIENT_NAME,i.name,p.quantity,p.date from clients c, inventory i, diagonosis d, appointments a join prescriptions p  where c.client_id = a.client_id AND a.app_id = d.app_id AND d.diagonosis_id = p.diagonosis_id AND i.invent_id = p.invent_id) as result group by pre_id order by date desc"));
        }

        private void viewr()
        {
            dgvr.DataSource = sf.view_db_records(new MySqlCommand(" select z.temp_id,s.s_name as service ,z.name as item,z.quantity,z.cost,z.date,z.pre_id from services s right join  (select  r.temp_id,r.service_id, i.name,r.quantity,r.cost,r.date,r.pre_id from inventory i right join receipt_temp r on r.invent_id = i.invent_id) z on s.service_id = z.service_id"));
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            receipt rp = new receipt();
            rp.ShowDialog();
        }

        private void dgvp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvp.Rows[e.RowIndex];
                bunifuCustomLabel7.Text = row.Cells[0].Value.ToString();
                bunifuCustomLabel1.Text = row.Cells[2].Value.ToString();
            }

        }
        private void fillcomb()
        {
            string query = "SELECT name FROM inventory where name != 'Null'";
            string display = "name";
            appointments.populatecombo(comboItm, query, display);
        }
        private void fillcomb2()
        {
            string query = "SELECT * FROM services";
            string display = "s_name";
            appointments.populatecombo(comboFname, query, display);
        }
        private void comboItm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bunifuCustomLabel10.Text = aps.getid("select invent_id from inventory where name = '" + comboItm.Text + "'", "invent_id");
            bunifuCustomLabel11.Text = aps.getid("select selling_price from inventory where name = '" + comboItm.Text + "'", "selling_price");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float cost = float.Parse(bunifuCustomLabel11.Text);
            int quantity = int.Parse(bunifuTextBox4.Text);
            float total = cost * quantity;
            string pre_id = bunifuCustomLabel7.Text;
            string invent_id = bunifuCustomLabel10.Text;
            DateTime date = DateTime.Now.Date;
            string trans_id = bunifuCustomLabel12.Text;
            try
            {
                if (tr.addtemp(invent_id, quantity, total, date, pre_id, trans_id))
                {
                    float cc = totalc();
                    bunifuTextBox2.Text = cc.ToString();
                    viewr();
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
        private float totalc()
        {
            string total = aps.getid("select SUM(cost) as total from receipt_temp", "total");
            float totalc = float.Parse(total);
            return totalc;
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            float tendered = float.Parse(bunifuTextBox1.Text);
            float cost = float.Parse(bunifuTextBox2.Text);
            float change = tendered - cost;
            bunifuTextBox3.Text = change.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboFname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bunifuCustomLabel10.Text = aps.getid("select service_id from services where s_name = '" + comboFname.Text + "'", "service_id");
            bunifuCustomLabel11.Text = aps.getid("select cost from services where s_name = '" + comboFname.Text + "'", "cost");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string sid = bunifuCustomLabel10.Text;
            float cost = float.Parse(bunifuCustomLabel11.Text);
            DateTime date = DateTime.Now.Date;
            string trans_id = bunifuCustomLabel12.Text;
            string pre_id = bunifuCustomLabel7.Text;
            try
            {
                if(tr.addtemps(sid,cost,date,trans_id))
                {
                    viewr();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds = seconds - 1;
                label3.Text = seconds + "";

            }
            if (label3.Text == "0")
            {
                seconds = 6;
                veiwp();
                
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            string sid = bunifuCustomLabel10.Text;
            float cost = float.Parse(bunifuCustomLabel11.Text);
            DateTime date = DateTime.Now.Date;
            string trans_id = bunifuCustomLabel12.Text;
            string pre_id = bunifuCustomLabel7.Text;
            try
            {
                if (tr.addtemps(sid, cost, date, trans_id))
                {
                    viewr();
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            float cost = float.Parse(bunifuCustomLabel11.Text);
            int quantity = int.Parse(bunifuTextBox4.Text);
            float total = cost * quantity;
            string pre_id = bunifuCustomLabel7.Text;
            string invent_id = bunifuCustomLabel10.Text;
            DateTime date = DateTime.Now.Date;
            string trans_id = bunifuCustomLabel12.Text;
            try
            {
                if (tr.addtemp(invent_id, quantity, total, date, pre_id, trans_id))
                {
                    float cc = totalc();
                    bunifuTextBox2.Text = cc.ToString();
                    viewr();
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

        private void btnRem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click_1(object sender, EventArgs e)
        {
            receipt rp = new receipt();
            rp.ShowDialog();
        }

        private void dgvp_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvp.Rows[e.RowIndex];
                bunifuCustomLabel7.Text = row.Cells[0].Value.ToString();
                bunifuCustomLabel1.Text = row.Cells[2].Value.ToString();
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            float cost = float.Parse(bunifuTextBox2.Text);
            float cash = float.Parse(bunifuTextBox1.Text);
            float change = cash - cost;
            bunifuTextBox3.Text = change.ToString();
        }
    }
}