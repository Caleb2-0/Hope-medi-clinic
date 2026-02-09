using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class supplier : Form
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
        private Rectangle recTxt9;
        private Rectangle recTxt10;
        private Rectangle recPnl1;

        suppliers sp = new suppliers();
        staffs sf = new staffs();
        public supplier()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut2 = new Rectangle(btnAdd.Location, btnAdd.Size);
            recBut3 = new Rectangle(btnUpdate.Location, btnUpdate.Size);
            recBut1 = new Rectangle(btnDel.Location, btnDel.Size);
            recTxt1 = new Rectangle(textSP.Location, textSP.Size);
            recTxt2 = new Rectangle(textAD.Location, textAD.Size);
            recTxt3 = new Rectangle(textPN.Location, textPN.Size);
            recTxt4 = new Rectangle(textEM.Location, textEM.Size);
            recTxt5 = new Rectangle(textPT.Location, textPT.Size);
            recTxt10 = new Rectangle(textDT.Location, textDT.Size);
            recTxt6 = new Rectangle(gunaLabel1.Location, gunaLabel1.Size);
            recPnl1 = new Rectangle(panel3.Location, panel3.Size);
            recTxt9 = new Rectangle(panel2.Location, panel2.Size);
        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnAdd, recBut2);
            resize_Control(btnUpdate, recBut3);
            resize_Control(btnDel, recBut1);
            resize_Control(textSP, recTxt1);
            resize_Control(textAD, recTxt2);
            resize_Control(textPN, recTxt3);
            resize_Control(textEM, recTxt4);
            resize_Control(textPT, recTxt5);
            resize_Control(textDT, recTxt10);
            resize_Control(panel3, recPnl1);
            resize_Control(gunaLabel1, recTxt6);
            resize_Control(panel2, recTxt9);

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

        private void supplier_Load(object sender, EventArgs e)
        {
            viewacc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textSP.Text == "" || textAD.Text == "" || textEM.Text == "" || textPN.Text == "" || textPT.Text == "" || textDT.Text == "")
            {
                MessageBox.Show("Fill in All Details", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string name = textSP.Text;
                string address = textAD.Text;
                string email = textEM.Text;
                string phone = textPN.Text;
                string payment = textPT.Text;
                string delivery = textDT.Text;
                string id = "SPLR" + staffs.userid();

                try
                {
                    if (sp.add_supplier(id, name, address, phone, email, payment, delivery))
                    {
                        MessageBox.Show("Supplier Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.btnClear(this);
                        viewacc();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (textSP.Text == "" || textAD.Text == "" || textEM.Text == "" || textPN.Text == "" || textPT.Text == "" || textDT.Text == "")
            {
                MessageBox.Show("Choose A Record To Remove", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Are You Sure You Want To Delete This Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string id = label1.Text;

                    try
                    {
                        if (sp.delete_sup(id))
                        {
                            MessageBox.Show("Supplier Record Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            control.btnClear(this);
                            viewacc();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error" + ex);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textSP.Text == "" || textAD.Text == "" || textEM.Text == "" || textPN.Text == "" || textPT.Text == "" || textDT.Text == "")
            {
                MessageBox.Show("Fill in All Details", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string name = textSP.Text;
                string address = textAD.Text;
                string email = textEM.Text;
                string phone = textPN.Text;
                string payment = textPT.Text;
                string delivery = textDT.Text;
                string id = label1.Text;

                try
                {
                    if (sp.update(id, name, address, phone, email, payment, delivery))
                    {
                        MessageBox.Show("Record Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.btnClear(this);
                        viewacc();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label1.Text = row.Cells[0].Value.ToString();
                textSP.Text = row.Cells[1].Value.ToString();
                textAD.Text = row.Cells[2].Value.ToString();
                textPN.Text = row.Cells[3].Value.ToString();
                textEM.Text = row.Cells[4].Value.ToString();
                textPT.Text = row.Cells[5].Value.ToString();
                textDT.Text = row.Cells[6].Value.ToString();
            }
        }
        private void viewacc()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT * FROM suppliers "));
        }
    }
}
