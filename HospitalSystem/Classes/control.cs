using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystem.Classes
{
    static class control
    {

        static bool isMax = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;

        public static void SetInitial(Form form)
        {
            old_loc = form.Location;
            old_size = form.Size;
            default_loc = form.Location;
            default_size = form.Size;
        }

        public static void DoMaximize(Form form, Button Maxbtn)
        {
            if (isMax == false)
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Maximize(form);
                isMax = true;
                Maxbtn.Text = "2";
            }
            else
            {
                form.Location = old_loc;
                form.Size = old_size;
                isMax = false;
                Maxbtn.Text = "1";
            }
        }

        public static void Minimize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Minimized;
        }

        static void Maximize(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);
        }

        public static void exit()
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Close The Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }

        public static void btnClear(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c.HasChildren)
                {
                    btnClear(c);
                }
            }

        }
        public static float cost(float num1, float num2)
        {
            float total = num1 * num2;
            return total;
        }

    }
}
