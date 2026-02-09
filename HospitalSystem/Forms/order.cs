using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class order : Form
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
        private Rectangle recBut24;
        private Rectangle recBut25;
        private Rectangle recBut26;
        private Rectangle recBut27;

        appointments appointments = new appointments();
        connection connect = new connection();
        appointments aps = new appointments();
        orders or = new orders();
        staffs sf = new staffs();
        public order()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(guna2GroupBox1.Location, guna2GroupBox1.Size);
            recBut2 = new Rectangle(btnAdd.Location, btnAdd.Size);
            recBut3 = new Rectangle(btnUPDT.Location, btnUPDT.Size);
            recBut4 = new Rectangle(btnCOMP.Location, btnCOMP.Size);
            recBut5 = new Rectangle(btnCancel.Location, btnCancel.Size);
            recBut6 = new Rectangle(comboName.Location, comboName.Size);
            recBut7 = new Rectangle(SupName.Location, SupName.Size);
            recBut8 = new Rectangle(textAM.Location, textAM.Size);
            recBut9 = new Rectangle(txtQnty.Location, txtQnty.Size);
            recBut10 = new Rectangle(Adtp1.Location, Adtp1.Size);
            recBut11 = new Rectangle(btnRes.Location, btnRes.Size);
            recBut12 = new Rectangle(btnGo.Location, btnGo.Size);
            recBut13 = new Rectangle(gunaLabel1.Location, gunaLabel1.Size);
            recBut14 = new Rectangle(gunaLabel2.Location, gunaLabel2.Size);
            recBut15 = new Rectangle(gunaLabel3.Location, gunaLabel3.Size);
            recBut16 = new Rectangle(gunaLabel4.Location, gunaLabel4.Size);
            recBut17 = new Rectangle(gunaLabel5.Location, gunaLabel5.Size);
            recBut18 = new Rectangle(gunaLabel6.Location, gunaLabel6.Size);
            recBut19 = new Rectangle(gunaLabel7.Location, gunaLabel7.Size);
            recBut20 = new Rectangle(gunaLabel8.Location, gunaLabel8.Size);
            recBut21 = new Rectangle(gunaLabel9.Location, gunaLabel9.Size);
            recBut22 = new Rectangle(dgv.Location, dgv.Size);
            recBut23 = new Rectangle(comboBox1.Location, comboBox1.Size);
            recBut24 = new Rectangle(textPT.Location, textPT.Size);
            recBut25 = new Rectangle(labelunit.Location, labelunit.Size);
            recBut26 = new Rectangle(gunaLabel12.Location, gunaLabel12.Size);
            recBut27 = new Rectangle(label2.Location, label2.Size);

        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(guna2GroupBox1, recBut1);
            resize_Control(btnAdd, recBut2);
            resize_Control(btnUPDT, recBut3);
            resize_Control(btnCOMP, recBut4);
            resize_Control(btnCancel, recBut5);
            resize_Control(comboName, recBut6);
            resize_Control(SupName, recBut7);
            resize_Control(textAM, recBut8);
            resize_Control(txtQnty, recBut9);
            resize_Control(Adtp1, recBut10);
            resize_Control(btnRes, recBut11);
            resize_Control(btnGo, recBut12);
            resize_Control(gunaLabel1, recBut13);
            resize_Control(gunaLabel2, recBut14);
            resize_Control(gunaLabel3, recBut15);
            resize_Control(gunaLabel4, recBut16);
            resize_Control(gunaLabel5, recBut17);
            resize_Control(gunaLabel6, recBut18);
            resize_Control(gunaLabel7, recBut19);
            resize_Control(gunaLabel8, recBut20);
            resize_Control(gunaLabel9, recBut21);
            resize_Control(dgv, recBut22);
            resize_Control(comboBox1, recBut23);
            resize_Control(textPT, recBut24);
            resize_Control(labelunit, recBut25);
            resize_Control(gunaLabel12, recBut26);
            resize_Control(label2, recBut27);


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

        public void vieword()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("select * from (select o.order_id as ORDERID,i.name as NAME,s.name as SUPPLIERNAME,o.quantity as QUANTITY,o.total_cost as TOTALCOST,o.date as DATE,o.state as STATE from inventory i, orders o, suppliers s where o.invent_id = i.invent_id AND s.supplier_id = o.supplier_id  ORDER BY ORDERID,DATE DESC) as result order by DATE DESC"));
        }

        public void filterorder()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("select * from (select o.order_id as ORDERID,i.name as NAME,s.name as SUPPLIERNAME,o.quantity as QUANTITY,o.total_cost as TOTALCOST,o.date as DATE,o.state as STATE from inventory i, orders o, suppliers s where o.invent_id = i.invent_id AND s.supplier_id = o.supplier_id AND STATE = '" + comboBox1.Text + "' AND DATE = '" + Adtp1.Value.ToString("yyyy-MM-dd") + "'  ORDER BY ORDERID,DATE DESC) as result order by DATE DESC"));
        }

        public void filterorder1()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("select * from (select o.order_id as ORDERID,i.name as NAME,s.name as SUPPLIERNAME,o.quantity as QUANTITY,o.total_cost as TOTALCOST,o.date as DATE,o.state as STATE from inventory i, orders o, suppliers s where o.invent_id = i.invent_id AND s.supplier_id = o.supplier_id AND DATE = '" + Adtp1.Value.ToString("yyyy-MM-dd") + "'  ORDER BY ORDERID,DATE DESC) as result order by DATE DESC"));
        }

        private void order_Load(object sender, EventArgs e)
        {
            Adtp1.Value = DateTime.Now;
            fillcombo();
            label5.Text = "ORD" + staffs.userid();
            vieword();
        }
        private void fillcombo()
        {
            string query = "SELECT name FROM inventory where name != 'Null'";
            string display = "name";
            appointments.populatecombo(comboName, query, display);
        }

        private void comboName_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT invent_id as id FROM inventory where name = '" + comboName.Text + "' LIMIT 1";
            string dis = "id";
            string invent_id = aps.getid(query, dis);
            label3.Text = invent_id;
            SupName.Items.Clear();
            fillcombo2();
        }

        private void fillcombo2()
        {
            string query = "select c.invent_id as id,c.name as name,a.name as SUPPLIERNAME from inventory c, inventory_supplier s, suppliers a where c.invent_id = s.invent_id AND a.supplier_id = s.supplier_id  AND c.invent_id = '" + label3.Text + "'";
            string display = "SUPPLIERNAME";
            appointments.populatecombo(SupName, query, display);
        }

        private void SupName_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM suppliers WHERE name = '" + SupName.Text + "'";
            string query1 = "SELECT * FROM inventory WHERE name = '" + comboName.Text + "'";
            string dt = "delivery_terms";
            string pt = "payment_terms";
            string un = "unit";
            string ct = "cost_price";
            string id = "supplier_id";
            string em = "email";
            textPT.Text = appointments.getid(query, pt);
            textDT.Text = appointments.getid(query, dt);
            labelunit.Text = appointments.getid(query1, un);
            label4.Text = appointments.getid(query1, ct);
            label6.Text = appointments.getid(query, id);
            label7.Text = appointments.getid(query, em);
        }

        private void txtQnty_TextChanged(object sender, EventArgs e)
        {
            if (txtQnty.Text != "")
            {
                float cost = float.Parse(label4.Text);
                float qnty = float.Parse(txtQnty.Text);
                float total = control.cost(qnty, cost);
                textAM.Text = total.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboName.Text == "" || txtQnty.Text == "" || SupName.Text == "")
            {
                MessageBox.Show("Please Fill All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string order_id = label5.Text;
                string invent_id = label3.Text;
                int quantity = int.Parse(txtQnty.Text);
                float total_cost = float.Parse(textAM.Text);
                DateTime order_date = DateTime.Now;
                string supplier_id = label6.Text;
                string item = aps.getid("select name from inventory where invent_id = '" + invent_id + "'", "name");
                string message = "Hello, We Would Like To Order " + item + ", Quantity " + quantity + ".  Thank You.";
                string subject = "Order";
                try
                {
                    if (aps.sendmail(label7.Text, subject, message))
                    {
                        try
                        {
                            if (or.add_order(order_id, invent_id, supplier_id, quantity, total_cost, order_date))
                            {
                                MessageBox.Show("Order Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                aps.sms(message);
                                vieword();
                                control.btnClear(this);
                                label5.Text = "ORD" + staffs.userid();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong,Mail Was Sent Couldn't Write To The Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Order Not Placed, Email To Supplier Couldnt Be Sent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Deliver The Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                or.deliver(label8.Text, "Delivered");
                vieword();
            }
            else
            {
                return;
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (comboName.Text == "" || txtQnty.Text == "" || SupName.Text == "")
            {
                MessageBox.Show("Please Fill All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string order_id = label5.Text;
                string invent_id = label3.Text;
                int quantity = int.Parse(txtQnty.Text);
                float total_cost = float.Parse(textAM.Text);
                string supplier_id = label6.Text;
                string query = "SELECT COUNT(*) AS COUNT FROM cart";
                string dis = "COUNT";

                try
                {
                    if (or.add_cart(order_id, invent_id, supplier_id, quantity, total_cost))
                    {
                        btnCArt.Text = "Cart( " + aps.getid(query, dis) + ")";
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

        private void btnCArt_Click(object sender, EventArgs e)
        {

            cart ct = new cart();
            ct.email = label7.Text;
            ct.ShowDialog();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label8.Text = row.Cells[0].Value.ToString();
                label10.Text = row.Cells[2].Value.ToString();
                try
                {
                    string query = "select ORDERID, group_concat( name separator ', ')as result from (select ORDERID, concat(NAME,' ',QUANTITY) as name from(select o.order_id as ORDERID,i.name as NAME,s.name as SUPPLIERNAME,o.quantity as QUANTITY from inventory i, orders o, suppliers s where o.invent_id = i.invent_id AND s.supplier_id = o.supplier_id AND o.order_id = '" + label8.Text + "') as result) as result order by ORDERID;\r\n";
                    label9.Text = aps.getid(query, "result");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnUPDT_Click(object sender, EventArgs e)
        {
            string order_id = label8.Text;
            string invent_id = label3.Text;
            int quantity = int.Parse(txtQnty.Text);
            float total_cost = float.Parse(textAM.Text);
            string subject = "Order Change";
            string supplier_message = "Hello, We Would Like To update The Previous Order With," + label9.Text + ".  Thank You";
            string supplier_email = aps.getid("select * from suppliers where name = '" + label10.Text + "'", "email");
            aps.sendmail(supplier_email, subject, supplier_message);
            aps.sms(supplier_message);


            try
            {
                if (aps.sendmail(supplier_email, subject, supplier_message))
                {
                    try
                    {
                        if (or.update_order(order_id, invent_id, quantity, total_cost))
                        {
                            MessageBox.Show("Order Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            aps.sms(supplier_message);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong,Couldn't Write to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("errro"+ex);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Something Went Wrong, Mail Wasn't Sent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void btnCOMP_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Cancel The Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string subject = "Orders";
                string supplier_message = "Hello, We Would Like To Cancel The Following Order of, " + label9.Text + ".  Thank You";
                string supplier_email = aps.getid("select * from suppliers where name = '" + label10.Text + "'", "email");


                try
                {
                    if (aps.sendmail(supplier_email, subject, supplier_message))
                    {
                        try
                        {
                            if (or.deliver(label8.Text, "Cancelled"))
                            {
                                aps.sms(supplier_message);
                                vieword();
                                MessageBox.Show("Order Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong During Database Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Error Cancelling The Order, Couldn't Send Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            vieword();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                filterorder1();
            }
            else
            {
                filterorder();
            }
        }
    }
}
