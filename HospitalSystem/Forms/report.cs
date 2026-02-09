using Bunifu.UI.WinForms.BunifuButton;
using HospitalSystem.Classes;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class report : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recBut4;
        private Rectangle recBut5;
        private Rectangle recBut6;

        connection conn = new connection();
        public report()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(bunifuButton1.Location, bunifuButton1.Size);
            recBut2 = new Rectangle(btnG.Location, btnG.Size);
            //  recBut3 = new Rectangle(panel1.Location, panel1.Size);
            recBut4 = new Rectangle(bunifuCustomLabel1.Location, bunifuCustomLabel1.Size);
            recBut5 = new Rectangle(dtp1.Location, dtp1.Size);
            recBut6 = new Rectangle(dtp2.Location, dtp2.Size);
        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(bunifuButton1, recBut1);
            resize_Control(btnG, recBut2);
            //resize_Control(panel1, recBut3);
            resize_Control(bunifuCustomLabel1, recBut4);
            resize_Control(dtp1, recBut5);
            resize_Control(dtp2, recBut6);
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

        private void btnG_Click(object sender, EventArgs e)
        {
            bunifuButton1.Visible = true;
            dtp1.Visible = false;
            dtp2.Visible = false;
            bunifuCustomLabel1.Visible = false;
            reportViewer1.Visible = true;
            btnG.Visible = false;
            ReportParameterCollection pdc = new ReportParameterCollection();
            pdc.Add(new ReportParameter("sd", dtp1.Value.Date.ToString("dd-MM-yyyy")));
            pdc.Add(new ReportParameter("ed", dtp2.Value.Date.ToString("dd-MM-yyyy")));
            ReportDataSource rec = new ReportDataSource("chart", reports());
            ReportDataSource inc = new ReportDataSource("income", income());
            ReportDataSource exp = new ReportDataSource("expenditure", expenditure());
            ReportDataSource prof = new ReportDataSource("profit", profit());
            ReportDataSource sal = new ReportDataSource("sales", sales());
            ReportDataSource expens = new ReportDataSource("expenses", expenses());
            reportViewer1.LocalReport.ReportPath = @"D:\L5DC\Assignments\HospitalSystem\HospitalSystem\freport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rec);
            reportViewer1.LocalReport.DataSources.Add(inc);
            reportViewer1.LocalReport.DataSources.Add(exp);
            reportViewer1.LocalReport.DataSources.Add(prof);
            reportViewer1.LocalReport.DataSources.Add(expens);
            reportViewer1.LocalReport.DataSources.Add(sal);
            reportViewer1.LocalReport.SetParameters(pdc);
            this.reportViewer1.RefreshReport();
        }

        private DataTable reports()
        {
            DataTable dt = new DataTable();
            conn.openConnect();
            MySqlCommand command = new MySqlCommand("select purpose, SUM(amount) as total from payments where date >= '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and date <= '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + "' group by purpose", conn.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            conn.closeConnect();
            return dt;
        }
        private DataTable profit()
        {
            DataTable dt = new DataTable();
            conn.openConnect();
            MySqlCommand command = new MySqlCommand("select(select sum(amount) from transactions where date >= '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and date <= '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + "') - (select sum(amount) from payments where date >= '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and date <= '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + "') as profit", conn.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            conn.closeConnect();
            return dt;
        }
        private DataTable income()
        {
            DataTable dt = new DataTable();
            conn.openConnect();
            MySqlCommand command = new MySqlCommand("select sum(amount) as income from transactions where date >= '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and date <= '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + "'", conn.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            conn.closeConnect();
            return dt;
        }
        private DataTable expenditure()
        {
            DataTable dt = new DataTable();
            conn.openConnect();
            MySqlCommand command = new MySqlCommand("select sum(amount) as expenditure from payments where date >= '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and date <= '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + "'", conn.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            conn.closeConnect();
            return dt;
        }
        private DataTable sales()
        {
            DataTable dt = new DataTable();
            conn.openConnect();
            MySqlCommand command = new MySqlCommand("select a.ITEM,a.QUANTITY,b.s_name as SERVICE,a.AMOUNT, a.date from services b right join ( select item,quantity,service_id,AMOUNT,cast(date as date) as DATE from (select r.name as ITEM,r.quantity as QUANTITY,t.service_id, t.amount as AMOUNT,t.date as DATE from (select p.pre_id,i.name,p.quantity from inventory i JOIN prescriptions p where i.invent_id = p.invent_id) r RIGHT JOIN transactions t ON t.pre_id = r.pre_id) as sales) a on b.service_id = a.service_id  where date >= '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and date <= '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + "' order by date desc", conn.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            conn.closeConnect();
            return dt;
        }
        private DataTable expenses()
        {
            DataTable dt = new DataTable();
            conn.openConnect();
            MySqlCommand command = new MySqlCommand("select r.name as item,r.supplier,r.quantity,p.name,p.cheque_number,p.amount,p.purpose,p.date from (select o.order_id, i.name,s.name as supplier ,o.quantity from inventory i ,suppliers s,orders o where o.invent_id = i.invent_id AND o.supplier_id = s.supplier_id) r RIGHT JOIN payments p ON p.order_id = r.order_id where date >= '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and date <= '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + "'", conn.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            conn.closeConnect();
            return dt;
        }

        private void report_Load(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            bunifuButton1.Visible = false;

        }

        private void btnC_Click(object sender, EventArgs e)
        {
           
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuButton1.Visible = false;
            reportViewer1.Visible = false;
            dtp1.Visible = true;
            dtp2.Visible = true;
            bunifuCustomLabel1.Visible = true;
            btnG.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bunifuButton1.Visible = false;
            reportViewer1.Visible = false;
            dtp1.Visible = true;
            dtp2.Visible = true;
            bunifuCustomLabel1.Visible = true;
            btnG.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bunifuButton1.Visible = true;
            dtp1.Visible = false;
            dtp2.Visible = false;
            bunifuCustomLabel1.Visible = false;
            reportViewer1.Visible = true;
            btnG.Visible = false;
            ReportParameterCollection pdc = new ReportParameterCollection();
            pdc.Add(new ReportParameter("sd", dtp1.Value.Date.ToString("dd-MM-yyyy")));
            pdc.Add(new ReportParameter("ed", dtp2.Value.Date.ToString("dd-MM-yyyy")));
            ReportDataSource rec = new ReportDataSource("chart", reports());
            ReportDataSource inc = new ReportDataSource("income", income());
            ReportDataSource exp = new ReportDataSource("expenditure", expenditure());
            ReportDataSource prof = new ReportDataSource("profit", profit());
            ReportDataSource sal = new ReportDataSource("sales", sales());
            ReportDataSource expens = new ReportDataSource("expenses", expenses());
            reportViewer1.LocalReport.ReportPath = @"D:\L5DC\Assignments\HospitalSystem\HospitalSystem\freport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rec);
            reportViewer1.LocalReport.DataSources.Add(inc);
            reportViewer1.LocalReport.DataSources.Add(exp);
            reportViewer1.LocalReport.DataSources.Add(prof);
            reportViewer1.LocalReport.DataSources.Add(expens);
            reportViewer1.LocalReport.DataSources.Add(sal);
            reportViewer1.LocalReport.SetParameters(pdc);
            this.reportViewer1.RefreshReport();
        }
    }
}
