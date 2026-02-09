using HospitalSystem.Classes;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class epass : Form
    {
        connection con = new connection();
        public string client_id { set; get; }
        public epass()
        {
            InitializeComponent();
        }

        private void epass_Load(object sender, EventArgs e)
        {
            label1.Text = client_id;
            ReportDataSource minfo = new ReportDataSource("info", mainInfo());
            reportViewer1.LocalReport.ReportPath = @"D:\L5DC\Assignments\HospitalSystem\HospitalSystem\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(minfo);
            reportViewer1.RefreshReport();
        }

        private DataTable mainInfo()
        {
            DataTable dt = new DataTable();
            con.openConnect();
            MySqlCommand command = new MySqlCommand("select * from (select diagonosis_id, client_id, first_name,last_name,date_of_birth,age, gender,address,past_conditions, symptoms,test,result, group_concat(name,' ' ,quantity) as prescription,date from (select t.diagonosis_id, c.client_id, c.first_name,c.last_name, c.date_of_birth,c.age, c.gender,c.address,c.past_conditions, t.symptoms,t.test,t.result, t.name,t.quantity,t.date from clients c,appointments a,(select d.app_id, r.diagonosis_id,d.symptoms,d.test,d.result, r.name,r.quantity,r.date from diagonosis d JOIN (SELECT d.diagonosis_id,i.name,d.quantity,d.date from prescriptions d JOIN inventory i ON i.invent_id = d.invent_id) r ON d.diagonosis_id = r.diagonosis_id) t where c.client_id = a.client_id AND a.app_id = t.app_id) as dis where client_id = '" + label1.Text + "' group by diagonosis_id) as result order by date desc", con.GetSqlConnection);
            MySqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            con.closeConnect();
            return dt;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
