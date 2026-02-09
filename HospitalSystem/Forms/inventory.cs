using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class inventory : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recBut4;
        private Rectangle recBut5;
        private Rectangle recBut6;
        private Rectangle recBut7;
        private Rectangle recBut8;
        private Rectangle recBut9;
        private Rectangle recBut10;
        private Rectangle recBut11;
        private Rectangle recBut12;
        private Rectangle recBut13;
        private Rectangle recBut14;
        private Rectangle recBut15;
        private Rectangle recBut16;
        private Rectangle recBut17;
        private Rectangle recBut18;
        private Rectangle recBut19;
        private Rectangle recBut20;
        private Rectangle recBut21;
        private Rectangle recBut22;
        private Rectangle recBut23;

        appointments aps = new appointments();
        connection connect = new connection();
        staffs sf = new staffs();
        clients cl = new clients();
        inventories inv = new inventories();
        public inventory()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(GrpBx.Location, GrpBx.Size);
            recBut2 = new Rectangle(btnAdd.Location, btnAdd.Size);
            recBut3 = new Rectangle(btnUP.Location, btnUP.Size);
            recBut4 = new Rectangle(btnRM.Location, btnRM.Size);
            //recBut5 = new Rectangle(btnSCH.Location, btnSCH.Size);
            //recBut6 = new Rectangle(btnRES.Location, btnRES.Size);
            recBut7 = new Rectangle(textName.Location, textName.Size);
            recBut8 = new Rectangle(textCP.Location, textCP.Size);
            recBut9 = new Rectangle(textSP.Location, textSP.Size);
            recBut10 = new Rectangle(textQ.Location, textQ.Size);
            //recBut11 = new Rectangle(textSRCH.Location, textSRCH.Size);
            recBut12 = new Rectangle(textUnit.Location, textUnit.Size);
            recBut13 = new Rectangle(gunaLabel1.Location, gunaLabel1.Size);
            recBut14 = new Rectangle(gunaLabel2.Location, gunaLabel2.Size);
            recBut15 = new Rectangle(gunaLabel3.Location, gunaLabel3.Size);
            recBut16 = new Rectangle(gunaLabel4.Location, gunaLabel4.Size);
            recBut17 = new Rectangle(gunaLabel5.Location, gunaLabel5.Size);
            recBut18 = new Rectangle(gunaLabel6.Location, gunaLabel6.Size);
            recBut19 = new Rectangle(gunaLabel7.Location, gunaLabel7.Size);
            recBut20 = new Rectangle(comboSup.Location, comboSup.Size);
            recBut21 = new Rectangle(dgv.Location, dgv.Size);
            recBut22 = new Rectangle(btnSV.Location, btnSV.Size);
            recBut23 = new Rectangle(btnITM.Location, btnITM.Size);
        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(GrpBx, recBut1);
            resize_Control(btnAdd, recBut2);
            resize_Control(btnUP, recBut3);
            resize_Control(btnRM, recBut4);
            //resize_Control(btnSCH, recBut5);
           // resize_Control(btnRES, recBut6);
            resize_Control(textName, recBut7);
            resize_Control(textCP, recBut8);
            resize_Control(textSP, recBut9);
            resize_Control(textQ, recBut10);
           // resize_Control(textSRCH, recBut11);
            resize_Control(textUnit, recBut12);
            resize_Control(gunaLabel1, recBut13);
            resize_Control(gunaLabel2, recBut14);
            resize_Control(gunaLabel3, recBut15);
            resize_Control(gunaLabel4, recBut16);
            resize_Control(gunaLabel5, recBut17);
            resize_Control(gunaLabel6, recBut18);
            resize_Control(gunaLabel7, recBut19);
            resize_Control(comboSup, recBut20);
            resize_Control(dgv, recBut21);
            resize_Control(btnSV, recBut22);
            resize_Control(btnITM, recBut23);

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

        private void inventory_Load(object sender, EventArgs e)
        {
            fillcombo();
            viewacc();
            btnITM.Visible = false;
        }
        private void fillcombo()
        {
            string query = "SELECT name FROM suppliers";
            string display = "name";
            appointments.populatecombo(comboSup, query, display);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textUnit.Enabled == true)
            {
                if (textName.Text == "" || textCP.Text == "" || textSP.Text == "" || textQ.Text == "" || textUnit.Text == "" || comboSup.Text == "")
                {
                    MessageBox.Show("Please Fill in All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string ivent_id = "IVENT-" + clients.userid();
                    string name = textName.Text;
                    string unit = textUnit.Text;
                    float cp = float.Parse(textCP.Text);
                    float sp = float.Parse(textSP.Text);
                    int qnty = Int32.Parse(textQ.Text);
                    string query = "SELECT invent_id as id FROM inventory where name = '" + textName.Text + "' LIMIT 1";
                    string dis = "id";
                    string invent_id = aps.getid(query, dis);
                    label1.Text = invent_id;

                    try
                    {
                        if (inv.checkinv(name))
                        {
                            try
                            {
                                if (inv.addsupid(label1.Text, label2.Text))
                                {
                                    MessageBox.Show("Item Paired To The Supplier Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Pairing Item to Supplier Failed,Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            try
                            {
                                if (inv.addinvt(ivent_id, name, unit, cp, sp, qnty))
                                {
                                    MessageBox.Show("Item added And Paired To Supplier successully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    control.btnClear(this);
                                    inv.addsupid(ivent_id, label2.Text);
                                    viewacc();
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
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            else
            {
                if (textName.Text == "" || textSP.Text == "")
                {
                    MessageBox.Show("Plese Fill All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string name = textName.Text;
                    float cost = float.Parse(textSP.Text);
                    string id = "SRVC-" + clients.userid();
                    try
                    {
                        if (inv.addsrv(id, name, cost))
                        {
                            MessageBox.Show("Service Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            control.btnClear(this);
                            viewserv();
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
                        return;
                    }
                }
            }
        }
        private void viewacc()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT * FROM inventory where name !='Null' "));
        }

        private void viewserv()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT service_id AS SERVICE_ID,s_name AS SERVICE_NAME,cost AS COST FROM services "));
        }

        private void textCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            gunaLabel7.Text = "All Services";
            viewserv();
            control.btnClear(this);
            btnSV.Visible = false;
            btnITM.Visible = true;
            comboSup.Enabled = false;
            textCP.Enabled = false;
            textQ.Enabled = false;
            textUnit.Enabled = false;
        }

        private void btnITM_Click(object sender, EventArgs e)
        {
            btnSV.Visible = true;
            btnITM.Visible = false;
            gunaLabel7.Text = "All Items";
            textCP.Enabled = true;
            textQ.Enabled = true;
            textUnit.Enabled = true;
            comboSup.Enabled = true;
            control.btnClear(this);
            viewacc();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && textUnit.Enabled == true)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label1.Text = row.Cells[0].Value.ToString();
                textName.Text = row.Cells[1].Value.ToString();
                textCP.Text = row.Cells[3].Value.ToString();
                textSP.Text = row.Cells[4].Value.ToString();
                textQ.Text = row.Cells[5].Value.ToString();
                textUnit.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label1.Text = row.Cells[0].Value.ToString();
                textName.Text = row.Cells[1].Value.ToString();
                textSP.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnRM_Click(object sender, EventArgs e)
        {
            if (textUnit.Enabled == true)
            {
                if (textName.Text == "" || textCP.Text == "" || textSP.Text == "" || textQ.Text == "" || textUnit.Text == "" || label1.Text == "label1")
                {
                    MessageBox.Show("Please Choose A Record To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult res = MessageBox.Show("Are You Sure You Want To Delete Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        string id = label1.Text;
                        try
                        {
                            if (inv.delinvt(id))
                            {
                                MessageBox.Show("Record Deleted", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                control.btnClear(this);
                                viewacc();
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
                            return;
                        }
                    }
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Are You Sure You Want To Delete Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string id = label1.Text;
                    try
                    {
                        if (inv.delsvc(id))
                        {
                            MessageBox.Show("Record Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewserv();
                            control.btnClear(this);
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
                        return;
                    }
                }
            }
        }
        private void btnUP_Click(object sender, EventArgs e)
        {
            if (textUnit.Enabled == true)
            {
                if (textName.Text == "" || textCP.Text == "" || textSP.Text == "" || textQ.Text == "" || textUnit.Text == "" || label1.Text == "label1")
                {
                    MessageBox.Show("Please Select A Record To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string ivent_id = label1.Text;
                    string name = textName.Text;
                    string unit = textUnit.Text;
                    float cp = float.Parse(textCP.Text);
                    float sp = float.Parse(textSP.Text);
                    int qnty = Int32.Parse(textQ.Text);

                    try
                    {
                        if (inv.updateinvt(ivent_id, name, unit, cp, sp, qnty))
                        {
                            MessageBox.Show("Record Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewacc();
                            control.btnClear(this);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong,Try Again");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            else
            {
                string id = label1.Text;
                string name = textName.Text;
                float cost = float.Parse(textSP.Text);
                try
                {
                    if (inv.updtsvc(id, name, cost))
                    {
                        MessageBox.Show("Record Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewserv();
                        control.btnClear(this);
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
                    return;
                }
            }
        }

        private void comboSup_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT supplier_id as id FROM suppliers where name = '" + comboSup.Text + "' LIMIT 1";
            string dis = "id";
            string supplier_id = aps.getid(query, dis);
            label2.Text = supplier_id;
        }
    }
}
