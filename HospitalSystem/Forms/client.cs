using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class client : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recTxt1;
        private Rectangle recTxt2;
        private Rectangle recTxt3;
        private Rectangle recTxt4;
        private Rectangle recTxt5;
        private Rectangle recTxt6;
        private Rectangle recTxt7;
        private Rectangle recTxt8;
        private Rectangle recTxt9;
        private Rectangle recTxt10;
        private Rectangle recPnl1;
        private Rectangle recPnl2;
        staffs sf = new staffs();
        clients clients = new clients();
        public client()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut2 = new Rectangle(btnAdd.Location, btnAdd.Size);
            recBut3 = new Rectangle(btnUpdate.Location, btnUpdate.Size);
            recBut1 = new Rectangle(btnDel.Location, btnDel.Size);
            recTxt1 = new Rectangle(textFname.Location, textFname.Size);
            recTxt2 = new Rectangle(textLname.Location, textLname.Size);
            recTxt3 = new Rectangle(textAddress.Location, textAddress.Size);
            recTxt4 = new Rectangle(textEmail.Location, textEmail.Size);
            recTxt5 = new Rectangle(textPN.Location, textPN.Size);
            recTxt9 = new Rectangle(DateTimePicker.Location, DateTimePicker.Size);
            recTxt10 = new Rectangle(ComboBoxG.Location, ComboBoxG.Size);
            recTxt7 = new Rectangle(gunaLabel2.Location, gunaLabel2.Size);
            recTxt8 = new Rectangle(gunaLabel3.Location, gunaLabel3.Size);
            recTxt6 = new Rectangle(gunaLabel1.Location, gunaLabel1.Size);
            recPnl1 = new Rectangle(panel3.Location, panel3.Size);
            recPnl2 = new Rectangle(panel2.Location, panel2.Size);
        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnAdd, recBut2);
            resize_Control(btnUpdate, recBut3);
            resize_Control(btnDel, recBut1);
            resize_Control(textFname, recTxt1);
            resize_Control(textLname, recTxt2);
            resize_Control(textEmail, recTxt3);
            resize_Control(textAddress, recTxt4);
            resize_Control(textPN, recTxt5);
            resize_Control(panel3, recPnl1);
            resize_Control(panel2, recPnl2);
            resize_Control(gunaLabel2, recTxt7);
            resize_Control(gunaLabel3, recTxt8);
            resize_Control(gunaLabel1, recTxt6);
            resize_Control(DateTimePicker, recTxt9);
            resize_Control(ComboBoxG, recTxt10);

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textAddress.Text == "" || textFname.Text == "" || textLname.Text == "" || textPN.Text == "")
            {
                MessageBox.Show("Fill in All Details");
                return;
            }
            else
            {

                string id = "CLT-" + staffs.userid();
                int age = staffs.Age(DateTimePicker.Value.Year);
                string fname = textFname.Text;
                string lname = textLname.Text;
                string address = textAddress.Text;
                string phone = textPN.Text;
                string email = textEmail.Text;
                string gender = ComboBoxG.Text;
                DateTime dob = DateTimePicker.Value.Date;

                try
                {
                    if (clients.add_client(id, fname, lname, gender, age, dob, address, phone, email))
                    {
                        MessageBox.Show("Client Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.btnClear(this);
                        viewacc();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                    return;
                }
            }
        }

        private void viewacc()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("Select client_id,first_name,last_name,gender,date_of_birth,age,address,phone_number,email From clients "));
        }

        private void client_Load(object sender, EventArgs e)
        {
            viewacc();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label1.Text = row.Cells[0].Value.ToString();
                textFname.Text = row.Cells[1].Value.ToString();
                textLname.Text = row.Cells[2].Value.ToString();
                ComboBoxG.Text = row.Cells[3].Value.ToString();
                DateTimePicker.Text = row.Cells[4].Value.ToString();
                textAddress.Text = row.Cells[6].Value.ToString();
                textPN.Text = row.Cells[7].Value.ToString();
                textEmail.Text = row.Cells[8].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textAddress.Text == "" | textFname.Text == "" | textLname.Text == "" | textPN.Text == "")
            {
                MessageBox.Show("Fill in All Details");
                return;
            }
            else
            {
                string id = label1.Text;
                int age = staffs.Age(DateTimePicker.Value.Year);
                string fname = textFname.Text;
                string lname = textLname.Text;
                string address = textAddress.Text;
                string phone = textPN.Text;
                string email = textEmail.Text;
                string gender = ComboBoxG.Text;
                DateTime dob = DateTimePicker.Value.Date;
                try
                {
                    if (clients.update(id, fname, lname, gender, age, dob, address, phone, email))
                    {
                        MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewacc();
                        control.btnClear(this);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Delete record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string c_id = label1.Text;
                try
                {
                    if (clients.delete_client(c_id))
                    {
                        MessageBox.Show("Deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.btnClear(this);
                        viewacc();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong,Try Again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                    return;
                }
            }
        }
    }
}
