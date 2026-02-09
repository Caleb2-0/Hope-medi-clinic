using HospitalSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Forms
{
    public partial class payment : Form
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

        staffs sf = new staffs();
        appointments aps = new appointments();
        payments pm = new payments();
        public payment()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(GrpBx.Location, GrpBx.Size);
            recBut2 = new Rectangle(btnPay.Location, btnPay.Size);
            recBut3 = new Rectangle(btnPay.Location, btnPay.Size);
            recBut4 = new Rectangle(txtSUP.Location, txtSUP.Size);
            recBut5 = new Rectangle(dtp.Location, dtp.Size);
            recBut6 = new Rectangle(comboPT.Location, comboPT.Size);
            recBut7 = new Rectangle(gunaLabel1.Location, gunaLabel1.Size);
            recBut8 = new Rectangle(gunaLabel2.Location, gunaLabel2.Size);
            recBut9 = new Rectangle(gunaLabel3.Location, gunaLabel3.Size);
            recBut10 = new Rectangle(gunaLabel4.Location, gunaLabel4.Size);
            recBut11 = new Rectangle(gunaLabel5.Location, gunaLabel5.Size);
            recBut12 = new Rectangle(gunaLabel6.Location, gunaLabel6.Size);
            recBut14 = new Rectangle(gunaLabel8.Location, gunaLabel8.Size);
            recBut15 = new Rectangle(gunaLabel9.Location, gunaLabel9.Size);
            recBut19 = new Rectangle(dgv.Location, dgv.Size);
            recBut16 = new Rectangle(btnOther.Location, btnOther.Size);
            recBut17 = new Rectangle(textCHQ.Location, textCHQ.Size);
            recBut18 = new Rectangle(txtAM.Location, txtAM.Size);

        }
        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(GrpBx, recBut1);
            resize_Control(btnPay, recBut2);
            resize_Control(btnPay, recBut3);
            resize_Control(txtSUP, recBut4);
            resize_Control(dtp, recBut5);
            resize_Control(comboPT, recBut6);
            resize_Control(gunaLabel1, recBut7);
            resize_Control(gunaLabel2, recBut8);
            resize_Control(gunaLabel3, recBut9);
            resize_Control(gunaLabel4, recBut10);
            resize_Control(gunaLabel5, recBut11);
            resize_Control(gunaLabel6, recBut12);
            resize_Control(gunaLabel8, recBut14);
            resize_Control(gunaLabel9, recBut15);
            resize_Control(dgv, recBut19);
            resize_Control(btnOther, recBut16);
            resize_Control(textCHQ, recBut17);
            resize_Control(txtAM, recBut18);

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

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {
            btnpaymnts.Visible = false;
            label4.Text = "p";
            viewapaymnets();
        }

        private void viewapaymnets()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT payment_id AS ID,order_id AS ORDERID,name AS NAME,cheque_number AS CHEQUE,amount AS AMOUNT,purpose as PURPOSE,date AS DATE FROM payments"));
        }

        private void filterpaymnets()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT payment_id AS ID,order_id AS ORDERID,name AS NAME,cheque_number AS CHEQUE,amount AS AMOUNT,purpose as PURPOSE,date AS DATE FROM payments WHERE date = '" + dtp.Value.Date.ToString("yyyy-MM-dd") + "'"));
        }

        public void vieword()
        {
            dgv.DataSource = sf.view_db_records(new MySqlCommand("SELECT o.ORDERID,o.NAME,o.SUPPLIERNAME,o.QUANTITY,o.TOTALCOST,o.DATE,o.STATE\r\nFROM (select * from (select o.order_id as ORDERID,i.name as NAME,s.name as SUPPLIERNAME,o.quantity as QUANTITY,o.total_cost as TOTALCOST,o.date as DATE,o.state as STATE from inventory i, orders o, suppliers s where o.invent_id = i.invent_id AND s.supplier_id = o.supplier_id  ORDER BY ORDERID,DATE DESC) as result order by DATE DESC) o\r\nLEFT JOIN payments p ON o.ORDERID = p.order_id WHERE p.payment_id IS NULL AND o.STATE = 'Delivered';"));
        }

        private void comboPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPT.Text == "Cash")
            {
                textCHQ.Clear();
                textCHQ.Enabled = false;
            }
            else
            {
                textCHQ.Enabled = true;
            }
        }

        private void btnpaymnts_Click(object sender, EventArgs e)
        {
            btnOther.Visible = true;
            btnpaymnts.Visible = false;
            comboPT.Visible = true;
            gunaLabel4.Text = "Payment Type";
            label4.Text = "p";

        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            btnpaymnts.Visible = true;
            btnOther.Visible = false;
            label4.Text = "op";

        }

        private void btnVP_Click(object sender, EventArgs e)
        {
            viewapaymnets();
        }

        private void btnNP_Click(object sender, EventArgs e)
        {
            vieword();
            label4.Text = "p";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                label1.Text = row.Cells[0].Value.ToString();
                txtSUP.Text = row.Cells[2].Value.ToString();

                try
                {
                    txtAM.Text = aps.getid("SELECT SUM(total_cost) AS total FROM orders WHERE order_id = '" + label1.Text + "'", "total");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string payment_id = "PYMNT" + staffs.userid();
            string order_id = label1.Text;
            double amount = double.Parse(txtAM.Text);
            DateTime datetime = DateTime.Now;
            DateTime date = datetime.Date;
            string cheque = textCHQ.Text;
            string purpose = guna2TextBox1.Text;
            string name = txtSUP.Text;

            if (label4.Text == "p")
            {
                if (txtSUP.Text == "" || txtAM.Text == "" || comboPT.Text == "")
                {
                    MessageBox.Show("{lease Fill All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        if (pm.addp(payment_id, order_id, cheque, amount, purpose, date))
                        {
                            MessageBox.Show("Payment Details Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            control.btnClear(this);
                            viewapaymnets();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                        return;
                    }
                }
            }
            else
            {
                if (txtSUP.Text == "" || txtAM.Text == "" || guna2TextBox1.Text == "")
                {
                    MessageBox.Show("{lease Fill All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        if (pm.addop(payment_id, name, cheque, amount, date, purpose))
                        {
                            MessageBox.Show("Payment Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            control.btnClear(this);
                            viewapaymnets();
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
                        MessageBox.Show("Error" + ex);
                        return;
                    }
                }
            }
        }

        private void txtAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
        private void btnRES_Click(object sender, EventArgs e)
        {
            viewapaymnets();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            filterpaymnets();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
