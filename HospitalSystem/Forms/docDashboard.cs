using HospitalSystem.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class docDashboard : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recTxt1;
        private Rectangle recPnl1;
        private Rectangle recPnl2;
        private Rectangle recPnl3;

        public string uname { set; get; }
        public string staff_id { get; set; }
        public static docDashboard instance;
        public Label plb;
        login log = new login();
        public docDashboard()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recTxt1 = new Rectangle(btnS.Location, btnS.Size);
            recPnl1 = new Rectangle(btnA.Location, btnA.Size);
            recPnl3 = new Rectangle(panel2.Location, panel2.Size);
            recBut1 = new Rectangle(bunifuButton1.Location, bunifuButton1.Size);
            instance = this;
            plb = label2;
        }
        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnS, recTxt1);
            resize_Control(btnA, recPnl1);
            resize_Control(panel2, recPnl3);
            resize_Control(bunifuButton1, recBut1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            control.DoMaximize(this, btn);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            control.Minimize(this);
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

        private void btnA_Click(object sender, EventArgs e)
        {
            showform(new docApointment());
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            docClient dc = new docClient();
            dc.id = label2.Text;
            showform(new docClient());
        }

        private void docDashboard_Load(object sender, EventArgs e)
        {
            label3.Text = uname;
            label2.Text = staff_id;
            showform(new cover());
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            passwordchange PC = new passwordchange();
            PC.uname = label3.Text;
            PC.ShowDialog();
        }
    }
}
