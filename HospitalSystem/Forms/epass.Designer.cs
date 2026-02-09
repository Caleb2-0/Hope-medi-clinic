namespace HospitalSystem.Forms
{
    partial class epass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(epass));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnV = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(920, 503);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnV
            // 
            this.btnV.AllowToggling = false;
            this.btnV.AnimationSpeed = 200;
            this.btnV.AutoGenerateColors = false;
            this.btnV.BackColor = System.Drawing.Color.Transparent;
            this.btnV.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.btnV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnV.BackgroundImage")));
            this.btnV.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnV.ButtonText = "CLOSE";
            this.btnV.ButtonTextMarginLeft = 0;
            this.btnV.ColorContrastOnClick = 45;
            this.btnV.ColorContrastOnHover = 45;
            this.btnV.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnV.CustomizableEdges = borderEdges1;
            this.btnV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnV.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnV.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnV.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnV.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnV.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnV.ForeColor = System.Drawing.Color.White;
            this.btnV.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnV.IconMarginLeft = 11;
            this.btnV.IconPadding = 10;
            this.btnV.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnV.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnV.IdleBorderRadius = 3;
            this.btnV.IdleBorderThickness = 1;
            this.btnV.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.btnV.IdleIconLeftImage = null;
            this.btnV.IdleIconRightImage = null;
            this.btnV.IndicateFocus = false;
            this.btnV.Location = new System.Drawing.Point(834, 2);
            this.btnV.Name = "btnV";
            this.btnV.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnV.onHoverState.BorderRadius = 3;
            this.btnV.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnV.onHoverState.BorderThickness = 1;
            this.btnV.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnV.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnV.onHoverState.IconLeftImage = null;
            this.btnV.onHoverState.IconRightImage = null;
            this.btnV.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnV.OnIdleState.BorderRadius = 3;
            this.btnV.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnV.OnIdleState.BorderThickness = 1;
            this.btnV.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.btnV.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnV.OnIdleState.IconLeftImage = null;
            this.btnV.OnIdleState.IconRightImage = null;
            this.btnV.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnV.OnPressedState.BorderRadius = 3;
            this.btnV.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnV.OnPressedState.BorderThickness = 1;
            this.btnV.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnV.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnV.OnPressedState.IconLeftImage = null;
            this.btnV.OnPressedState.IconRightImage = null;
            this.btnV.Size = new System.Drawing.Size(86, 22);
            this.btnV.TabIndex = 9;
            this.btnV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnV.TextMarginLeft = 0;
            this.btnV.UseDefaultRadiusAndThickness = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // epass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "epass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "epass";
            this.Load += new System.EventHandler(this.epass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnV;
        private System.Windows.Forms.Label label1;
    }
}