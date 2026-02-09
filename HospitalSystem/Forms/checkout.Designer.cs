namespace HospitalSystem.Forms
{
    partial class checkout
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuCustomLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuCustomLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuCustomLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuCustomLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuCustomLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuCustomLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuCustomLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuCustomLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuCustomLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dgvr = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bunifuTextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboFname = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboItm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuButton4 = new Guna.UI2.WinForms.Guna2Button();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvr)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dgvp);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(2, -1);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(427, 496);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Prescriptions";
            // 
            // dgvp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvp.BackgroundColor = System.Drawing.Color.White;
            this.dgvp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvp.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvp.EnableHeadersVisualStyles = false;
            this.dgvp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvp.Location = new System.Drawing.Point(3, 44);
            this.dgvp.Name = "dgvp";
            this.dgvp.RowHeadersVisible = false;
            this.dgvp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvp.Size = new System.Drawing.Size(421, 495);
            this.dgvp.TabIndex = 25;
            this.dgvp.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvp.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvp.ThemeStyle.ReadOnly = false;
            this.dgvp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvp.ThemeStyle.RowsStyle.Height = 22;
            this.dgvp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvp_CellClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuButton4);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuCustomLabel12);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.bunifuCustomLabel13);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.dgvr);
            this.panel1.Controls.Add(this.bunifuTextBox4);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuTextBox3);
            this.panel1.Controls.Add(this.bunifuTextBox1);
            this.panel1.Controls.Add(this.bunifuTextBox2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboFname);
            this.panel1.Controls.Add(this.comboItm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(435, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 538);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(102, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(164, 30);
            this.bunifuCustomLabel1.TabIndex = 35;
            this.bunifuCustomLabel1.Text = "customer name";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(262, 75);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(136, 30);
            this.bunifuCustomLabel12.TabIndex = 34;
            this.bunifuCustomLabel12.Text = "Choose Item";
            this.bunifuCustomLabel12.Visible = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(262, 89);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(136, 30);
            this.bunifuCustomLabel7.TabIndex = 33;
            this.bunifuCustomLabel7.Text = "Choose Item";
            this.bunifuCustomLabel7.Visible = false;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(255, 75);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(136, 30);
            this.bunifuCustomLabel10.TabIndex = 32;
            this.bunifuCustomLabel10.Text = "Choose Item";
            this.bunifuCustomLabel10.Visible = false;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(252, 30);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(136, 30);
            this.bunifuCustomLabel11.TabIndex = 31;
            this.bunifuCustomLabel11.Text = "Choose Item";
            this.bunifuCustomLabel11.Visible = false;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(191, 89);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(48, 30);
            this.bunifuCustomLabel9.TabIndex = 30;
            this.bunifuCustomLabel9.Text = "Qty";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(9, 17);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(92, 30);
            this.bunifuCustomLabel13.TabIndex = 25;
            this.bunifuCustomLabel13.Text = "Services";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(9, 89);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(136, 30);
            this.bunifuCustomLabel8.TabIndex = 26;
            this.bunifuCustomLabel8.Text = "Choose Item";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(242, 430);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(148, 30);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "Total Amount";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(9, 430);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(59, 30);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "Cash";
            // 
            // dgvr
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvr.BackgroundColor = System.Drawing.Color.White;
            this.dgvr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvr.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvr.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvr.EnableHeadersVisualStyles = false;
            this.dgvr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvr.Location = new System.Drawing.Point(10, 193);
            this.dgvr.Name = "dgvr";
            this.dgvr.RowHeadersVisible = false;
            this.dgvr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvr.Size = new System.Drawing.Size(365, 237);
            this.dgvr.TabIndex = 2;
            this.dgvr.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvr.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvr.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvr.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvr.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvr.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvr.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvr.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvr.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvr.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvr.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvr.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvr.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvr.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvr.ThemeStyle.ReadOnly = false;
            this.dgvr.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvr.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvr.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvr.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvr.ThemeStyle.RowsStyle.Height = 22;
            this.dgvr.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvr.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // bunifuTextBox4
            // 
            this.bunifuTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox4.DefaultText = "";
            this.bunifuTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bunifuTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bunifuTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox4.DisabledState.Parent = this.bunifuTextBox4;
            this.bunifuTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox4.FocusedState.Parent = this.bunifuTextBox4;
            this.bunifuTextBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox4.HoverState.Parent = this.bunifuTextBox4;
            this.bunifuTextBox4.Location = new System.Drawing.Point(196, 124);
            this.bunifuTextBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuTextBox4.Name = "bunifuTextBox4";
            this.bunifuTextBox4.PasswordChar = '\0';
            this.bunifuTextBox4.PlaceholderText = "";
            this.bunifuTextBox4.SelectedText = "";
            this.bunifuTextBox4.ShadowDecoration.Parent = this.bunifuTextBox4;
            this.bunifuTextBox4.Size = new System.Drawing.Size(55, 36);
            this.bunifuTextBox4.TabIndex = 24;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(0, 460);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(87, 30);
            this.bunifuCustomLabel6.TabIndex = 27;
            this.bunifuCustomLabel6.Text = "Change";
            // 
            // bunifuTextBox3
            // 
            this.bunifuTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox3.DefaultText = "";
            this.bunifuTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bunifuTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bunifuTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox3.DisabledState.Parent = this.bunifuTextBox3;
            this.bunifuTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox3.FocusedState.Parent = this.bunifuTextBox3;
            this.bunifuTextBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox3.HoverState.Parent = this.bunifuTextBox3;
            this.bunifuTextBox3.Location = new System.Drawing.Point(96, 465);
            this.bunifuTextBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuTextBox3.Name = "bunifuTextBox3";
            this.bunifuTextBox3.PasswordChar = '\0';
            this.bunifuTextBox3.PlaceholderText = "";
            this.bunifuTextBox3.SelectedText = "";
            this.bunifuTextBox3.ShadowDecoration.Parent = this.bunifuTextBox3;
            this.bunifuTextBox3.Size = new System.Drawing.Size(137, 27);
            this.bunifuTextBox3.TabIndex = 23;
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
            this.bunifuTextBox1.Location = new System.Drawing.Point(96, 433);
            this.bunifuTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderText = "";
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.ShadowDecoration.Parent = this.bunifuTextBox1;
            this.bunifuTextBox1.Size = new System.Drawing.Size(137, 27);
            this.bunifuTextBox1.TabIndex = 22;
            this.bunifuTextBox1.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.DefaultText = "";
            this.bunifuTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bunifuTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bunifuTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox2.DisabledState.Parent = this.bunifuTextBox2;
            this.bunifuTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox2.FocusedState.Parent = this.bunifuTextBox2;
            this.bunifuTextBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox2.HoverState.Parent = this.bunifuTextBox2;
            this.bunifuTextBox2.Location = new System.Drawing.Point(247, 458);
            this.bunifuTextBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            this.bunifuTextBox2.PasswordChar = '\0';
            this.bunifuTextBox2.PlaceholderText = "";
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.ShadowDecoration.Parent = this.bunifuTextBox2;
            this.bunifuTextBox2.Size = new System.Drawing.Size(135, 39);
            this.bunifuTextBox2.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 2;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(260, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(52, 36);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BorderRadius = 2;
            this.bunifuButton1.CheckedState.Parent = this.bunifuButton1;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.CustomImages.Parent = this.bunifuButton1;
            this.bunifuButton1.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.HoverState.Parent = this.bunifuButton1;
            this.bunifuButton1.Location = new System.Drawing.Point(196, 52);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.ShadowDecoration.Parent = this.bunifuButton1;
            this.bunifuButton1.Size = new System.Drawing.Size(60, 31);
            this.bunifuButton1.TabIndex = 19;
            this.bunifuButton1.Text = "ADD";
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "00";
            this.label3.Visible = false;
            // 
            // comboFname
            // 
            this.comboFname.BackColor = System.Drawing.Color.Transparent;
            this.comboFname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboFname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFname.FocusedColor = System.Drawing.Color.Empty;
            this.comboFname.FocusedState.Parent = this.comboFname;
            this.comboFname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFname.FormattingEnabled = true;
            this.comboFname.HoverState.Parent = this.comboFname;
            this.comboFname.ItemHeight = 30;
            this.comboFname.ItemsAppearance.Parent = this.comboFname;
            this.comboFname.Location = new System.Drawing.Point(7, 50);
            this.comboFname.Name = "comboFname";
            this.comboFname.ShadowDecoration.Parent = this.comboFname;
            this.comboFname.Size = new System.Drawing.Size(183, 36);
            this.comboFname.TabIndex = 16;
            this.comboFname.SelectionChangeCommitted += new System.EventHandler(this.comboFname_SelectionChangeCommitted);
            // 
            // comboItm
            // 
            this.comboItm.BackColor = System.Drawing.Color.Transparent;
            this.comboItm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboItm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboItm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboItm.FocusedColor = System.Drawing.Color.Empty;
            this.comboItm.FocusedState.Parent = this.comboItm;
            this.comboItm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboItm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboItm.FormattingEnabled = true;
            this.comboItm.HoverState.Parent = this.comboItm;
            this.comboItm.ItemHeight = 30;
            this.comboItm.ItemsAppearance.Parent = this.comboItm;
            this.comboItm.Location = new System.Drawing.Point(10, 124);
            this.comboItm.Name = "comboItm";
            this.comboItm.ShadowDecoration.Parent = this.comboItm;
            this.comboItm.Size = new System.Drawing.Size(180, 36);
            this.comboItm.TabIndex = 14;
            this.comboItm.SelectionChangeCommitted += new System.EventHandler(this.comboItm_SelectionChangeCommitted);
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.BorderRadius = 2;
            this.bunifuButton4.CheckedState.Parent = this.bunifuButton4;
            this.bunifuButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton4.CustomImages.Parent = this.bunifuButton4;
            this.bunifuButton4.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.HoverState.Parent = this.bunifuButton4;
            this.bunifuButton4.Location = new System.Drawing.Point(318, 501);
            this.bunifuButton4.Name = "bunifuButton4";
            this.bunifuButton4.ShadowDecoration.Parent = this.bunifuButton4;
            this.bunifuButton4.Size = new System.Drawing.Size(64, 34);
            this.bunifuButton4.TabIndex = 21;
            this.bunifuButton4.Text = "DONE";
            this.bunifuButton4.Click += new System.EventHandler(this.bunifuButton4_Click_1);
            // 
            // countdown
            // 
            this.countdown.Enabled = true;
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkout";
            this.Text = "checkout";
            this.Load += new System.EventHandler(this.checkout_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboItm;
        private Guna.UI2.WinForms.Guna2ComboBox comboFname;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button bunifuButton1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button bunifuButton4;
        private Guna.UI2.WinForms.Guna2TextBox bunifuTextBox2;
        private Guna.UI2.WinForms.Guna2TextBox bunifuTextBox1;
        private Guna.UI2.WinForms.Guna2TextBox bunifuTextBox3;
        private Guna.UI2.WinForms.Guna2TextBox bunifuTextBox4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvr;
        private Guna.UI2.WinForms.Guna2DataGridView dgvp;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel13;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel9;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel4;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel8;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel5;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel6;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel1;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel12;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel7;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel10;
        private Guna.UI.WinForms.GunaLabel bunifuCustomLabel11;
    }
}