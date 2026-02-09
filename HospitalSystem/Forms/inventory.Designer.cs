namespace HospitalSystem.Forms
{
    partial class inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpBx = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnITM = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnRM = new Guna.UI2.WinForms.Guna2Button();
            this.btnUP = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.comboSup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.textQ = new Guna.UI2.WinForms.Guna2TextBox();
            this.textUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.textCP = new Guna.UI2.WinForms.Guna2TextBox();
            this.textName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBx
            // 
            this.GrpBx.Controls.Add(this.btnITM);
            this.GrpBx.Controls.Add(this.gunaLabel6);
            this.GrpBx.Controls.Add(this.gunaLabel4);
            this.GrpBx.Controls.Add(this.gunaLabel2);
            this.GrpBx.Controls.Add(this.gunaLabel5);
            this.GrpBx.Controls.Add(this.gunaLabel3);
            this.GrpBx.Controls.Add(this.gunaLabel1);
            this.GrpBx.Controls.Add(this.btnSV);
            this.GrpBx.Controls.Add(this.btnRM);
            this.GrpBx.Controls.Add(this.btnUP);
            this.GrpBx.Controls.Add(this.btnAdd);
            this.GrpBx.Controls.Add(this.comboSup);
            this.GrpBx.Controls.Add(this.textSP);
            this.GrpBx.Controls.Add(this.textQ);
            this.GrpBx.Controls.Add(this.textUnit);
            this.GrpBx.Controls.Add(this.textCP);
            this.GrpBx.Controls.Add(this.textName);
            this.GrpBx.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.GrpBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GrpBx.Location = new System.Drawing.Point(0, -1);
            this.GrpBx.Name = "GrpBx";
            this.GrpBx.ShadowDecoration.Parent = this.GrpBx;
            this.GrpBx.Size = new System.Drawing.Size(824, 213);
            this.GrpBx.TabIndex = 0;
            this.GrpBx.Text = "Items And Services";
            // 
            // btnITM
            // 
            this.btnITM.CheckedState.Parent = this.btnITM;
            this.btnITM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnITM.CustomImages.Parent = this.btnITM;
            this.btnITM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(145)))), ((int)(((byte)(113)))));
            this.btnITM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnITM.ForeColor = System.Drawing.Color.White;
            this.btnITM.HoverState.Parent = this.btnITM;
            this.btnITM.Location = new System.Drawing.Point(704, 170);
            this.btnITM.Name = "btnITM";
            this.btnITM.ShadowDecoration.Parent = this.btnITM;
            this.btnITM.Size = new System.Drawing.Size(107, 36);
            this.btnITM.TabIndex = 4;
            this.btnITM.Text = "ITEMS";
            this.btnITM.Click += new System.EventHandler(this.btnITM_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(491, 122);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(149, 24);
            this.gunaLabel6.TabIndex = 3;
            this.gunaLabel6.Text = "Quantity In Stock";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(245, 122);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(178, 24);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Selling Price (MWK)";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(8, 122);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(153, 24);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Cost Price(MWK)";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(491, 44);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(80, 24);
            this.gunaLabel5.TabIndex = 3;
            this.gunaLabel5.Text = "Supplier";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(245, 44);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(115, 24);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Unit Of Issue";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 44);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(61, 24);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Name";
            // 
            // btnSV
            // 
            this.btnSV.CheckedState.Parent = this.btnSV;
            this.btnSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSV.CustomImages.Parent = this.btnSV;
            this.btnSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(145)))), ((int)(((byte)(113)))));
            this.btnSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSV.ForeColor = System.Drawing.Color.White;
            this.btnSV.HoverState.Parent = this.btnSV;
            this.btnSV.Location = new System.Drawing.Point(704, 170);
            this.btnSV.Name = "btnSV";
            this.btnSV.ShadowDecoration.Parent = this.btnSV;
            this.btnSV.Size = new System.Drawing.Size(107, 36);
            this.btnSV.TabIndex = 2;
            this.btnSV.Text = "SERVICES";
            this.btnSV.Click += new System.EventHandler(this.btnSV_Click);
            // 
            // btnRM
            // 
            this.btnRM.CheckedState.Parent = this.btnRM;
            this.btnRM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRM.CustomImages.Parent = this.btnRM;
            this.btnRM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRM.ForeColor = System.Drawing.Color.White;
            this.btnRM.HoverState.Parent = this.btnRM;
            this.btnRM.Location = new System.Drawing.Point(704, 128);
            this.btnRM.Name = "btnRM";
            this.btnRM.ShadowDecoration.Parent = this.btnRM;
            this.btnRM.Size = new System.Drawing.Size(107, 36);
            this.btnRM.TabIndex = 2;
            this.btnRM.Text = "REMOVE";
            this.btnRM.Click += new System.EventHandler(this.btnRM_Click);
            // 
            // btnUP
            // 
            this.btnUP.CheckedState.Parent = this.btnUP;
            this.btnUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUP.CustomImages.Parent = this.btnUP;
            this.btnUP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(145)))), ((int)(((byte)(113)))));
            this.btnUP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUP.ForeColor = System.Drawing.Color.White;
            this.btnUP.HoverState.Parent = this.btnUP;
            this.btnUP.Location = new System.Drawing.Point(704, 86);
            this.btnUP.Name = "btnUP";
            this.btnUP.ShadowDecoration.Parent = this.btnUP;
            this.btnUP.Size = new System.Drawing.Size(107, 36);
            this.btnUP.TabIndex = 2;
            this.btnUP.Text = "UPDATE";
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(145)))), ((int)(((byte)(113)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(704, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(107, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboSup
            // 
            this.comboSup.BackColor = System.Drawing.Color.Transparent;
            this.comboSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboSup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSup.FocusedColor = System.Drawing.Color.Empty;
            this.comboSup.FocusedState.Parent = this.comboSup;
            this.comboSup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboSup.FormattingEnabled = true;
            this.comboSup.HoverState.Parent = this.comboSup;
            this.comboSup.ItemHeight = 30;
            this.comboSup.ItemsAppearance.Parent = this.comboSup;
            this.comboSup.Location = new System.Drawing.Point(491, 73);
            this.comboSup.Name = "comboSup";
            this.comboSup.ShadowDecoration.Parent = this.comboSup;
            this.comboSup.Size = new System.Drawing.Size(188, 36);
            this.comboSup.TabIndex = 1;
            this.comboSup.SelectedValueChanged += new System.EventHandler(this.comboSup_SelectedValueChanged);
            // 
            // textSP
            // 
            this.textSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSP.DefaultText = "";
            this.textSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSP.DisabledState.Parent = this.textSP;
            this.textSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSP.FocusedState.Parent = this.textSP;
            this.textSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSP.HoverState.Parent = this.textSP;
            this.textSP.Location = new System.Drawing.Point(245, 154);
            this.textSP.Margin = new System.Windows.Forms.Padding(24, 28, 24, 28);
            this.textSP.Name = "textSP";
            this.textSP.PasswordChar = '\0';
            this.textSP.PlaceholderText = "";
            this.textSP.SelectedText = "";
            this.textSP.ShadowDecoration.Parent = this.textSP;
            this.textSP.Size = new System.Drawing.Size(188, 36);
            this.textSP.TabIndex = 0;
            this.textSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSP_KeyPress);
            // 
            // textQ
            // 
            this.textQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textQ.DefaultText = "";
            this.textQ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textQ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textQ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textQ.DisabledState.Parent = this.textQ;
            this.textQ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textQ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textQ.FocusedState.Parent = this.textQ;
            this.textQ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textQ.HoverState.Parent = this.textQ;
            this.textQ.Location = new System.Drawing.Point(491, 156);
            this.textQ.Margin = new System.Windows.Forms.Padding(24, 28, 24, 28);
            this.textQ.Name = "textQ";
            this.textQ.PasswordChar = '\0';
            this.textQ.PlaceholderText = "";
            this.textQ.SelectedText = "";
            this.textQ.ShadowDecoration.Parent = this.textQ;
            this.textQ.Size = new System.Drawing.Size(188, 36);
            this.textQ.TabIndex = 0;
            this.textQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQ_KeyPress);
            // 
            // textUnit
            // 
            this.textUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUnit.DefaultText = "";
            this.textUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUnit.DisabledState.Parent = this.textUnit;
            this.textUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUnit.FocusedState.Parent = this.textUnit;
            this.textUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUnit.HoverState.Parent = this.textUnit;
            this.textUnit.Location = new System.Drawing.Point(245, 73);
            this.textUnit.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.textUnit.Name = "textUnit";
            this.textUnit.PasswordChar = '\0';
            this.textUnit.PlaceholderText = "";
            this.textUnit.SelectedText = "";
            this.textUnit.ShadowDecoration.Parent = this.textUnit;
            this.textUnit.Size = new System.Drawing.Size(188, 36);
            this.textUnit.TabIndex = 0;
            this.textUnit.TextChanged += new System.EventHandler(this.textUnit_TextChanged);
            this.textUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUnit_KeyPress);
            // 
            // textCP
            // 
            this.textCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCP.DefaultText = "";
            this.textCP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textCP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textCP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCP.DisabledState.Parent = this.textCP;
            this.textCP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCP.FocusedState.Parent = this.textCP;
            this.textCP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCP.HoverState.Parent = this.textCP;
            this.textCP.Location = new System.Drawing.Point(8, 154);
            this.textCP.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.textCP.Name = "textCP";
            this.textCP.PasswordChar = '\0';
            this.textCP.PlaceholderText = "";
            this.textCP.SelectedText = "";
            this.textCP.ShadowDecoration.Parent = this.textCP;
            this.textCP.Size = new System.Drawing.Size(188, 36);
            this.textCP.TabIndex = 0;
            this.textCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCP_KeyPress);
            // 
            // textName
            // 
            this.textName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textName.DefaultText = "";
            this.textName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.DisabledState.Parent = this.textName;
            this.textName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.FocusedState.Parent = this.textName;
            this.textName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.HoverState.Parent = this.textName;
            this.textName.Location = new System.Drawing.Point(8, 73);
            this.textName.Margin = new System.Windows.Forms.Padding(6);
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PlaceholderText = "";
            this.textName.SelectedText = "";
            this.textName.ShadowDecoration.Parent = this.textName;
            this.textName.Size = new System.Drawing.Size(188, 36);
            this.textName.TabIndex = 0;
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            // 
            // dgv
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.ColumnHeadersHeight = 25;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(0, 261);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(824, 277);
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
            this.dgv.ThemeStyle.HeaderStyle.Height = 25;
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
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(8, 227);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(80, 24);
            this.gunaLabel7.TabIndex = 3;
            this.gunaLabel7.Text = "All Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.GrpBx);
            this.Controls.Add(this.gunaLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventory";
            this.Text = "inventory";
            this.Load += new System.EventHandler(this.inventory_Load);
            this.GrpBx.ResumeLayout(false);
            this.GrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GrpBx;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btnRM;
        private Guna.UI2.WinForms.Guna2Button btnUP;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox comboSup;
        private Guna.UI2.WinForms.Guna2TextBox textSP;
        private Guna.UI2.WinForms.Guna2TextBox textQ;
        private Guna.UI2.WinForms.Guna2TextBox textUnit;
        private Guna.UI2.WinForms.Guna2TextBox textCP;
        private Guna.UI2.WinForms.Guna2TextBox textName;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2Button btnSV;
        private Guna.UI2.WinForms.Guna2Button btnITM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}