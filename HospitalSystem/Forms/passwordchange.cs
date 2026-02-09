using HospitalSystem.Classes;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{

    public partial class passwordchange : Form
    {
        public string uname { get; set; }
        staffs sf = new staffs();
        public passwordchange()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Close,Unsaved Changes Will Be Lost?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                txtCP.UseSystemPasswordChar = false;
                txtP.UseSystemPasswordChar = false;
            }
            else
            {
                txtP.UseSystemPasswordChar = true;
                txtCP.UseSystemPasswordChar = true;
            }
        }

        private void passwordchange_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = uname;
            txtP.UseSystemPasswordChar = true;
            txtCP.UseSystemPasswordChar = true;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (txtP.Text == "" || txtCP.Text == "")
            {
                MessageBox.Show("Please Fill In All Details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var username = bunifuCustomLabel2.Text;
            var input = txtP.Text;
            var input1 = txtCP.Text;
            var hasSymbols = new Regex(@"[! @#$%^&*_+=[{}/?.,><';:-]+");
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");


            if (!hasNumber.IsMatch(input))
            {
                MessageBox.Show("Password Must Contain Atleast One Number");
                return;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                MessageBox.Show("Password Must Contain Atleast One Uppercase");
                return;
            }
            else if (!hasLowerChar.IsMatch(input))
            {
                MessageBox.Show("Password Must Contain Atleast One Lowercase");
                return;
            }
            else if (!hasSymbols.IsMatch(input))
            {
                MessageBox.Show("Password Must Contain Atleast One Special Character");
                return;
            }

            else if (input.ToCharArray().Length < 8)
            {
                MessageBox.Show("Password Must Have Atleast 8 Characters");
                return;
            }

            else if (input != input1)
            {
                MessageBox.Show("Passwords Don't Match!");
                txtP.Clear();
                txtCP.Clear();
                return;
            }

            else
            {
                try
                {
                    if (sf.updatep(username, input))
                    {
                        MessageBox.Show("Password Changed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
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
                }

            }
        }
    }
}
