namespace HospitalSystem.Forms
{
    partial class report
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnG = new Guna.UI2.WinForms.Guna2Button();
            this.dtp1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bunifuCustomLabel1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 42);
            this.panel2.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalSystem.freport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 408);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
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
            this.bunifuButton1.Location = new System.Drawing.Point(724, 3);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.ShadowDecoration.Parent = this.bunifuButton1;
            this.bunifuButton1.Size = new System.Drawing.Size(73, 33);
            this.bunifuButton1.TabIndex = 20;
            this.bunifuButton1.Text = "CLOSE";
            this.bunifuButton1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnG
            // 
            this.btnG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnG.BorderColor = System.Drawing.SystemColors.Control;
            this.btnG.BorderThickness = 3;
            this.btnG.CheckedState.Parent = this.btnG;
            this.btnG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnG.CustomImages.Parent = this.btnG;
            this.btnG.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.ForeColor = System.Drawing.Color.White;
            this.btnG.HoverState.Parent = this.btnG;
            this.btnG.Location = new System.Drawing.Point(288, 272);
            this.btnG.Name = "btnG";
            this.btnG.ShadowDecoration.Parent = this.btnG;
            this.btnG.Size = new System.Drawing.Size(224, 45);
            this.btnG.TabIndex = 21;
            this.btnG.Text = "GENERATE";
            this.btnG.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtp1
            // 
            this.dtp1.CheckedState.Parent = this.dtp1;
            this.dtp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp1.HoverState.Parent = this.dtp1;
            this.dtp1.Location = new System.Drawing.Point(42, 155);
            this.dtp1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShadowDecoration.Parent = this.dtp1;
            this.dtp1.Size = new System.Drawing.Size(281, 36);
            this.dtp1.TabIndex = 22;
            this.dtp1.Value = new System.DateTime(2023, 8, 15, 12, 38, 56, 200);
            // 
            // dtp2
            // 
            this.dtp2.CheckedState.Parent = this.dtp2;
            this.dtp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp2.HoverState.Parent = this.dtp2;
            this.dtp2.Location = new System.Drawing.Point(479, 155);
            this.dtp2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp2.Name = "dtp2";
            this.dtp2.ShadowDecoration.Parent = this.dtp2;
            this.dtp2.Size = new System.Drawing.Size(281, 36);
            this.dtp2.TabIndex = 22;
            this.dtp2.Value = new System.DateTime(2023, 8, 15, 12, 38, 56, 200);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(153, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(509, 37);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Choose The Dates For The Report";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button bunifuButton1;
        private Guna.UI2.WinForms.Guna2Button btnG;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp2;
        private System.Windows.Forms.Label bunifuCustomLabel1;
    }
}