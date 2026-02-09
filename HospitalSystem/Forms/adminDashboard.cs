using HospitalSystem.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace HospitalSystem.Forms
{
    public partial class adminDashboard : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recTxt1;
        private Rectangle recTxt2;
        private Rectangle recPnl1;
        int seconds = 3600;
        public string uname { set; get; }
        public string staff_id { get; set; }
        public static adminDashboard instance;
        public Label plb;
        login log = new login();
        public adminDashboard()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(btnStaff.Location, btnStaff.Size);
            recBut1 = new Rectangle(btnClients.Location, btnClients.Size);
            recBut1 = new Rectangle(btnInventory.Location, btnInventory.Size);
            recBut1 = new Rectangle(btnOrders.Location, btnOrders.Size);
            recBut1 = new Rectangle(btnSales.Location, btnSales.Size);
            recBut1 = new Rectangle(btnPayments.Location, btnPayments.Size);
            recBut1 = new Rectangle(btnReports.Location, btnReports.Size);
            recPnl1 = new Rectangle(panelFill.Location, panelFill.Size);
            recPnl1 = new Rectangle(panel1.Location, button1.Size);
            recBut1 = new Rectangle(btnAppointments.Location, btnAppointments.Size);
            recTxt2 = new Rectangle(btnLog.Location, btnLog.Size);
            instance = this;
            plb = label2;
        }
        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnStaff, recBut1);
            resize_Control(btnClients, recBut1);
            resize_Control(btnSuppliers, recBut1);
            resize_Control(btnAppointments, recBut1);
            resize_Control(btnInventory, recBut1);
            resize_Control(btnOrders, recBut1);
            resize_Control(btnSales, recBut1);
            resize_Control(btnPayments, recBut1);
            resize_Control(btnReports, recBut1);
            resize_Control(panelFill, recTxt1);
            resize_Control(panel1, recPnl1);
            resize_Control(btnLog, recTxt2);
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
        public void showform(object form)
        {
            if (this.panelFill.Controls.Count > 0)
                this.panelFill.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelFill.Controls.Add(f);
            this.panelFill.Tag = f;
            f.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Sign Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string time = DateTime.Now.ToLongTimeString();
                string staff_id = label2.Text;
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            control.Minimize(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            control.DoMaximize(this, btn);
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            label2.Text = staff_id;
            label1.Text = uname;
            invent();
            showform(new cover());
        }

        private void invent()
        {
            
            connection con = new connection();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT COUNT(*) as quant FROM inventory WHERE quantity < 30 and name != 'Null'",con.GetSqlConnection);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int quant = int.Parse(dt.Rows[0]["quant"].ToString());
                if(quant > 0)
                {
                    MessageBox.Show("You Have " + quant + "Item(s) Running Low,Please Head To Inventory Tab To Fix This", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    return;
                }
                

            }
            else
            {
                return;
            }

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            showform(new staff());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            showform(new client());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            showform(new supplier());
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            showform(new appointment());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            showform(new order());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            showform(new inventory());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            showform(new transaction());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            showform(new payment());
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            showform(new systemlogs());
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
                seconds = 3600;
                invent();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            showform(new report());
        }

        private void panelFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            passwordchange cp = new passwordchange();
            cp.uname = label1.Text;
            cp.ShowDialog();
        }

        private void btnLog_Click_1(object sender, EventArgs e)
        {
            showform(new systemlogs());
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            passwordchange ps = new passwordchange();
            ps.ShowDialog();
        }
    }
}
