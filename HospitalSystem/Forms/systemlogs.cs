using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class systemlogs : Form
    {
        staffs sf = new staffs();
        public systemlogs()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
        private void viewlog()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT s.first_name AS FIRSTNAME,s.last_name AS LASTNAME,l.login_time AS LOGIN_TIME,l.logout_time AS LOGOUT_TIME,l.date AS DATE FROM staffs s JOIN logs l WHERE s.staff_id = l.staff_id ORDER BY date DESC"));
        }

        private void systemlogs_Load(object sender, EventArgs e)
        {
            viewlog();
        }
    }
}
