namespace HospitalSystem.Forms
{
    partial class staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxG = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.textUN = new Guna.UI2.WinForms.Guna2TextBox();
            this.textEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPN = new Guna.UI2.WinForms.Guna2TextBox();
            this.textLname = new Guna.UI2.WinForms.Guna2TextBox();
            this.textAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.textFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnRes = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuButton1);
            this.panel2.Controls.Add(this.bunifuTextBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.ComboBoxG);
            this.panel2.Controls.Add(this.DateTimePicker);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.gunaLabel3);
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Controls.Add(this.textUN);
            this.panel2.Controls.Add(this.textEmail);
            this.panel2.Controls.Add(this.textPN);
            this.panel2.Controls.Add(this.textLname);
            this.panel2.Controls.Add(this.textAddress);
            this.panel2.Controls.Add(this.textFname);
            this.panel2.Location = new System.Drawing.Point(1, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 243);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Transparent;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.comboBox2.FocusedState.Parent = this.comboBox2;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.HoverState.Parent = this.comboBox2;
            this.comboBox2.ItemHeight = 30;
            this.comboBox2.Items.AddRange(new object[] {
            "Admin",
            "Receiptionist",
            "Doctor",
            "LabTech",
            "Other"});
            this.comboBox2.ItemsAppearance.Parent = this.comboBox2;
            this.comboBox2.Location = new System.Drawing.Point(324, 204);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.ShadowDecoration.Parent = this.comboBox2;
            this.comboBox2.Size = new System.Drawing.Size(275, 36);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ComboBoxG
            // 
            this.ComboBoxG.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxG.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxG.FocusedState.Parent = this.ComboBoxG;
            this.ComboBoxG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxG.FormattingEnabled = true;
            this.ComboBoxG.HoverState.Parent = this.ComboBoxG;
            this.ComboBoxG.ItemHeight = 30;
            this.ComboBoxG.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ComboBoxG.ItemsAppearance.Parent = this.ComboBoxG;
            this.ComboBoxG.Location = new System.Drawing.Point(324, 166);
            this.ComboBoxG.Name = "ComboBoxG";
            this.ComboBoxG.ShadowDecoration.Parent = this.ComboBoxG;
            this.ComboBoxG.Size = new System.Drawing.Size(275, 36);
            this.ComboBoxG.TabIndex = 16;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CheckedState.Parent = this.DateTimePicker;
            this.DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.HoverState.Parent = this.DateTimePicker;
            this.DateTimePicker.Location = new System.Drawing.Point(11, 166);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.ShadowDecoration.Parent = this.DateTimePicker;
            this.DateTimePicker.Size = new System.Drawing.Size(281, 36);
            this.DateTimePicker.TabIndex = 15;
            this.DateTimePicker.Value = new System.DateTime(2023, 8, 15, 12, 38, 56, 200);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(319, 136);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 30);
            this.gunaLabel3.TabIndex = 13;
            this.gunaLabel3.Text = "GENDER";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(11, 136);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(166, 30);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "DATE OF BIRTH";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(136, 210);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(156, 30);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "DESIGNATION";
            // 
            // textUN
            // 
            this.textUN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUN.DefaultText = "";
            this.textUN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUN.DisabledState.Parent = this.textUN;
            this.textUN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUN.FocusedState.Parent = this.textUN;
            this.textUN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUN.HoverState.Parent = this.textUN;
            this.textUN.Location = new System.Drawing.Point(324, 99);
            this.textUN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textUN.Name = "textUN";
            this.textUN.PasswordChar = '\0';
            this.textUN.PlaceholderText = "Username";
            this.textUN.SelectedText = "";
            this.textUN.ShadowDecoration.Parent = this.textUN;
            this.textUN.Size = new System.Drawing.Size(275, 39);
            this.textUN.TabIndex = 6;
            // 
            // textEmail
            // 
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.DefaultText = "";
            this.textEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.DisabledState.Parent = this.textEmail;
            this.textEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.FocusedState.Parent = this.textEmail;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.HoverState.Parent = this.textEmail;
            this.textEmail.Location = new System.Drawing.Point(7, 99);
            this.textEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textEmail.Name = "textEmail";
            this.textEmail.PasswordChar = '\0';
            this.textEmail.PlaceholderText = "Email";
            this.textEmail.SelectedText = "";
            this.textEmail.ShadowDecoration.Parent = this.textEmail;
            this.textEmail.Size = new System.Drawing.Size(285, 39);
            this.textEmail.TabIndex = 7;
            // 
            // textPN
            // 
            this.textPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPN.DefaultText = "";
            this.textPN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPN.DisabledState.Parent = this.textPN;
            this.textPN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPN.FocusedState.Parent = this.textPN;
            this.textPN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPN.HoverState.Parent = this.textPN;
            this.textPN.Location = new System.Drawing.Point(324, 52);
            this.textPN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textPN.Name = "textPN";
            this.textPN.PasswordChar = '\0';
            this.textPN.PlaceholderText = "Phone Number";
            this.textPN.SelectedText = "";
            this.textPN.ShadowDecoration.Parent = this.textPN;
            this.textPN.Size = new System.Drawing.Size(275, 39);
            this.textPN.TabIndex = 8;
            // 
            // textLname
            // 
            this.textLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLname.DefaultText = "";
            this.textLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLname.DisabledState.Parent = this.textLname;
            this.textLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLname.FocusedState.Parent = this.textLname;
            this.textLname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLname.HoverState.Parent = this.textLname;
            this.textLname.Location = new System.Drawing.Point(324, 4);
            this.textLname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textLname.Name = "textLname";
            this.textLname.PasswordChar = '\0';
            this.textLname.PlaceholderText = "Last Name";
            this.textLname.SelectedText = "";
            this.textLname.ShadowDecoration.Parent = this.textLname;
            this.textLname.Size = new System.Drawing.Size(275, 39);
            this.textLname.TabIndex = 9;
            // 
            // textAddress
            // 
            this.textAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAddress.DefaultText = "";
            this.textAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAddress.DisabledState.Parent = this.textAddress;
            this.textAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAddress.FocusedState.Parent = this.textAddress;
            this.textAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAddress.HoverState.Parent = this.textAddress;
            this.textAddress.Location = new System.Drawing.Point(7, 52);
            this.textAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textAddress.Name = "textAddress";
            this.textAddress.PasswordChar = '\0';
            this.textAddress.PlaceholderText = "Address";
            this.textAddress.SelectedText = "";
            this.textAddress.ShadowDecoration.Parent = this.textAddress;
            this.textAddress.Size = new System.Drawing.Size(285, 39);
            this.textAddress.TabIndex = 10;
            // 
            // textFname
            // 
            this.textFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textFname.DefaultText = "";
            this.textFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textFname.DisabledState.Parent = this.textFname;
            this.textFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textFname.FocusedState.Parent = this.textFname;
            this.textFname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textFname.HoverState.Parent = this.textFname;
            this.textFname.Location = new System.Drawing.Point(7, 4);
            this.textFname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textFname.Name = "textFname";
            this.textFname.PasswordChar = '\0';
            this.textFname.PlaceholderText = "First Name";
            this.textFname.SelectedText = "";
            this.textFname.ShadowDecoration.Parent = this.textFname;
            this.textFname.Size = new System.Drawing.Size(285, 39);
            this.textFname.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv);
            this.panel3.Location = new System.Drawing.Point(12, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 241);
            this.panel3.TabIndex = 7;
            // 
            // dgv
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(799, 241);
            this.dgv.TabIndex = 1;
            this.dgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 22;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDel.BorderThickness = 3;
            this.btnDel.CheckedState.Parent = this.btnDel;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.CustomImages.Parent = this.btnDel;
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.HoverState.Parent = this.btnDel;
            this.btnDel.Location = new System.Drawing.Point(622, 213);
            this.btnDel.Name = "btnDel";
            this.btnDel.ShadowDecoration.Parent = this.btnDel;
            this.btnDel.Size = new System.Drawing.Size(194, 58);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "DELETE";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRes.BorderThickness = 3;
            this.btnRes.CheckedState.Parent = this.btnRes;
            this.btnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRes.CustomImages.Parent = this.btnRes;
            this.btnRes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.ForeColor = System.Drawing.Color.White;
            this.btnRes.HoverState.Parent = this.btnRes;
            this.btnRes.Location = new System.Drawing.Point(622, 155);
            this.btnRes.Name = "btnRes";
            this.btnRes.ShadowDecoration.Parent = this.btnRes;
            this.btnRes.Size = new System.Drawing.Size(194, 58);
            this.btnRes.TabIndex = 8;
            this.btnRes.Text = "RESET";
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BorderColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.BorderThickness = 3;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(622, 97);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(194, 58);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BorderThickness = 3;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(622, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(194, 58);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(368, 4);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(73, 30);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "STAFF";
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bunifuTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bunifuTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox1.DisabledState.Parent = this.bunifuTextBox1;
            this.bunifuTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.FocusedState.Parent = this.bunifuTextBox1;
            this.bunifuTextBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.HoverState.Parent = this.bunifuTextBox1;
            this.bunifuTextBox1.Location = new System.Drawing.Point(325, 201);
            this.bunifuTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderText = "Enter Role";
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.ShadowDecoration.Parent = this.bunifuTextBox1;
            this.bunifuTextBox1.Size = new System.Drawing.Size(202, 39);
            this.bunifuTextBox1.TabIndex = 18;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton1.BorderColor = System.Drawing.SystemColors.Control;
            this.bunifuButton1.BorderThickness = 3;
            this.bunifuButton1.CheckedState.Parent = this.bunifuButton1;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.CustomImages.Parent = this.bunifuButton1;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.HoverState.Parent = this.bunifuButton1;
            this.bunifuButton1.Location = new System.Drawing.Point(526, 202);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.ShadowDecoration.Parent = this.bunifuButton1;
            this.bunifuButton1.Size = new System.Drawing.Size(73, 41);
            this.bunifuButton1.TabIndex = 19;
            this.bunifuButton1.Text = "RESET";
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click_1);
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 538);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staff";
            this.Text = "staff";
            this.Load += new System.EventHandler(this.staff_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox textUN;
        private Guna.UI2.WinForms.Guna2TextBox textEmail;
        private Guna.UI2.WinForms.Guna2TextBox textPN;
        private Guna.UI2.WinForms.Guna2TextBox textLname;
        private Guna.UI2.WinForms.Guna2TextBox textAddress;
        private Guna.UI2.WinForms.Guna2TextBox textFname;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnRes;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxG;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2TextBox bunifuTextBox1;
        private Guna.UI2.WinForms.Guna2Button bunifuButton1;
    }
}