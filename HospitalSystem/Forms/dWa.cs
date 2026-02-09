using HospitalSystem.Classes;
using System;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class dWa : Form
    {
        public string id { set; get; }
        public string name { set; get; }
        public string lname { set; get; }
        diagonosis da = new diagonosis();
        appointments aps = new appointments();
        public dWa()
        {
            InitializeComponent();
        }

        private void btnP_Click(object sender, EventArgs e)
        {

        }

        private void btnF_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Close This Window?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            string client_id = aps.getid("select * from clients where first_name = '" + txtFN.Text + "' AND last_name = '" + txtLN.Text + "'", "client_id");
            string staff_id = label1.Text;
            string state = "Active";
            string app_id = "APMT:" + staffs.userid();
            DateTime date = DateTime.Now.Date;
            string time1 = DateTime.Now.ToLongTimeString();
            TimeSpan.TryParse(time1, out TimeSpan time);
            string dia_id = "DGNS:" + staffs.userid();
            string symp = txtSP.Text;
            string test = txtT.Text;
            try
            {
                if (aps.addApp(app_id, staff_id, client_id, date, time, state))
                {
                    try
                    {
                        if (da.addD(dia_id, app_id, symp, test, date))
                        {
                            MessageBox.Show("Diagonosis Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Diagonosis Couldn't Be Added,Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dWa_Load(object sender, EventArgs e)
        {
            label1.Text = docDashboard.instance.plb.Text;
            txtFN.Text = name;
            txtLN.Text = lname;
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
