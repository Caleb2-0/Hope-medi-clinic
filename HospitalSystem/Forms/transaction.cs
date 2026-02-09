using HospitalSystem.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalSystem.Forms
{
    public partial class transaction : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut9;
        private Rectangle recBut11;

        appointments appointments = new appointments();
        connection connect = new connection();
        staffs sf = new staffs();
        public transaction()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut9 = new Rectangle(gunaLabel3.Location, gunaLabel3.Size);
            recBut11 = new Rectangle(dgv.Location, dgv.Size);

        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(gunaLabel3, recBut9);
            resize_Control(dgv, recBut11);

        }
        private void viewtrans()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("select trans_id as ID,name as ITEM,s_name as SERVICE,amount as COST,date as DATE from (select i.name,f.s_name,f.trans_id,f.pre_id,f.amount,f.date from inventory i right join ( select s.s_name,d.trans_id,d.pre_id,d.invent_id,d.amount,d.date from services s right join ( select t.trans_id,p.pre_id,p.invent_id,p.quantity,t.service_id, t.amount,t.date from transactions t left join prescriptions p on p.pre_id = t.pre_id) d on s.service_id = d.service_id) f on i.invent_id = f.invent_id) as res order by DATE desc"));
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

        private void transaction_Load(object sender, EventArgs e)
        {
            viewtrans();
        }
    }
}
