using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class staff : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recBut4;
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
        private Rectangle recTxt11;
        private Rectangle recPnl1;
        private Rectangle recRdo1;
        private Rectangle recRdo2;
        private Rectangle recPnl2;
        staffs sf = new staffs();
        public staff()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut2 = new Rectangle(btnAdd.Location, btnAdd.Size);
            recBut3 = new Rectangle(btnUpdate.Location, btnUpdate.Size);
            recBut4 = new Rectangle(btnRes.Location, btnRes.Size);
            recBut1 = new Rectangle(btnDel.Location, btnDel.Size);
            recTxt1 = new Rectangle(textFname.Location, textFname.Size);
            recTxt2 = new Rectangle(textLname.Location, textLname.Size);
            recTxt3 = new Rectangle(textAddress.Location, textAddress.Size);
            recTxt4 = new Rectangle(textEmail.Location, textEmail.Size);
            recTxt5 = new Rectangle(textPN.Location, textPN.Size);
            recTxt6 = new Rectangle(textUN.Location, textUN.Size);
            recTxt9 = new Rectangle(DateTimePicker.Location, DateTimePicker.Size);
            recTxt10 = new Rectangle(ComboBoxG.Location, ComboBoxG.Size);
            recRdo1 = new Rectangle(comboBox2.Location, comboBox2.Size);
            recRdo2 = new Rectangle(gunaLabel1.Location, gunaLabel1.Size);
            recTxt7 = new Rectangle(gunaLabel2.Location, gunaLabel2.Size);
            recTxt11 = new Rectangle(gunaLabel4.Location, gunaLabel4.Size);
            recTxt8 = new Rectangle(gunaLabel3.Location, gunaLabel3.Size);
            recPnl1 = new Rectangle(panel3.Location, panel3.Size);
            recPnl2 = new Rectangle(panel2.Location, panel2.Size);

        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnAdd, recBut2);
            resize_Control(btnUpdate, recBut3);
            resize_Control(btnRes, recBut4);
            resize_Control(btnDel, recBut1);
            resize_Control(textFname, recTxt1);
            resize_Control(textLname, recTxt2);
            resize_Control(textEmail, recTxt3);
            resize_Control(textAddress, recTxt4);
            resize_Control(textPN, recTxt5);
            resize_Control(textUN, recTxt6);
            resize_Control(comboBox2, recRdo1);
            resize_Control(gunaLabel1, recRdo2);
            resize_Control(panel3, recPnl1);
            resize_Control(panel2, recPnl2);
            resize_Control(gunaLabel2, recTxt7);
            resize_Control(gunaLabel3, recTxt8);
            resize_Control(gunaLabel4, recTxt11);
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

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
        private void viewacc()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("select * from (Select staff_id as ID,first_name as FIRSTNAME,last_name as LASTNAME,gender,date_of_birth as DATE_OF_BIRTH,age as AGE,address as ADDRESS,phone_number as NUMBER,email as EMAIL,username as USERNAME,role as DESIGNATION From staffs) as res"));
        }

        private void staff_Load(object sender, EventArgs e)
        {
            viewacc();
            bunifuButton1.Visible = false;
            bunifuTextBox1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(bunifuTextBox1.Visible == true)
            {
                if (textAddress.Text == "" || textFname.Text == "" || textLname.Text == "" || textPN.Text == "" || textUN.Text == "")
                {
                    MessageBox.Show("Fill in All Details");
                    return;
                }
                else
                {
                    string id = "STF-" + staffs.userid();
                    int age = staffs.Age(DateTimePicker.Value.Year);
                    string pass = "Null";
                    string fname = textFname.Text;
                    string lname = textLname.Text;
                    string address = textAddress.Text;
                    string phone = textPN.Text;
                    string email = textEmail.Text;
                    string uname = "Null";
                    string role = bunifuTextBox1.Text;
                    string gender = ComboBoxG.Text;
                    DateTime dob = DateTimePicker.Value.Date;

                    try
                    {
                        if (sf.add_staff(id, fname, lname, gender, age, dob, address, phone, email, uname, pass, role))
                        {
                            MessageBox.Show("Record Added","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewacc();
                            control.btnClear(this);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong,Try Again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            else
            {
                if (textAddress.Text == "" || textFname.Text == "" || textLname.Text == "" || textPN.Text == "" || textUN.Text == "")
                {
                    MessageBox.Show("Fill in All Details");
                    return;
                }
                else
                {

                    string id = "STF-" + staffs.userid();
                    int age = staffs.Age(DateTimePicker.Value.Year);
                    string pass = "default";
                    string fname = textFname.Text;
                    string lname = textLname.Text;
                    string address = textAddress.Text;
                    string phone = textPN.Text;
                    string email = textEmail.Text;
                    string uname = textUN.Text;
                    string role = comboBox2.Text;
                    string gender = ComboBoxG.Text;
                    DateTime dob = DateTimePicker.Value.Date;

                    try
                    {
                        if (sf.checkuname(uname))
                        {
                            MessageBox.Show("Username Is Already Taken,Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (sf.add_staff(id, fname, lname, gender, age, dob, address, phone, email, uname, pass, role))
                        {
                            MessageBox.Show("Staff Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            control.btnClear(this);
                            viewacc();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong");
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label1.Text = row.Cells[0].Value.ToString();
                textFname.Text = row.Cells[1].Value.ToString();
                textLname.Text = row.Cells[2].Value.ToString();
                textAddress.Text = row.Cells[6].Value.ToString();
                textPN.Text = row.Cells[7].Value.ToString();
                textEmail.Text = row.Cells[8].Value.ToString();
                textUN.Text = row.Cells[9].Value.ToString();
                comboBox2.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Delete record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string staff_id = label1.Text;
                try
                {
                    if (sf.delete_user(staff_id))
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textAddress.Text == "" | textFname.Text == "" | textLname.Text == "" | textPN.Text == "" | textUN.Text == "")
            {
                MessageBox.Show("Fill in All Details");
                return;
            }
            else
            {
                string id = label1.Text;
                string fname = textFname.Text;
                string lname = textLname.Text;
                string address = textAddress.Text;
                string phone = textPN.Text;
                string email = textEmail.Text;
                string uname = textUN.Text;
                string role = comboBox2.Text;
                try
                {
                    if (sf.update(id, fname, lname, address, phone, email, uname, role))
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

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (textAddress.Text == "" || textFname.Text == "" || textLname.Text == "" || textPN.Text == "" || textUN.Text == "")
            {
                MessageBox.Show("Fill in All Details");
                return;
            }
            else
            {
                string id = label1.Text;
                string pass = "default";

                try
                {
                    if (sf.reset(id, pass))
                    {
                        MessageBox.Show("Password Reset Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.btnClear(this);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Other")
            {
                comboBox2.Visible = false;
                bunifuButton1.Visible = true;
                bunifuTextBox1.Visible = true;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Visible = false;
            bunifuButton1.Visible = false;
            comboBox2.Visible = true;
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            bunifuTextBox1.Visible = false;
            bunifuButton1.Visible = false;
            comboBox2.Visible = true;
        }
    }
}
