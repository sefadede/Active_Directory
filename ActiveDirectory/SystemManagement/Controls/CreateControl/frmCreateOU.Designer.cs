namespace SystemManagement.Controls
{
    partial class frmCreateOU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateOU));
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbOU = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCreateOU = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescpriction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOUName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOU.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cmbOU);
            this.panel2.Controls.Add(this.btnCreateOU);
            this.panel2.Controls.Add(this.txtDescpriction);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtOUName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 206);
            this.panel2.TabIndex = 4;
            // 
            // cmbOU
            // 
            this.cmbOU.Location = new System.Drawing.Point(78, 41);
            this.cmbOU.Name = "cmbOU";
            this.cmbOU.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cmbOU.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmbOU.Properties.Appearance.Options.UseBackColor = true;
            this.cmbOU.Properties.Appearance.Options.UseForeColor = true;
            this.cmbOU.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cmbOU.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOU.Size = new System.Drawing.Size(219, 20);
            this.cmbOU.TabIndex = 4;
            this.cmbOU.SelectedIndexChanged += new System.EventHandler(this.cmbOU_SelectedIndexChanged);
            // 
            // btnCreateOU
            // 
            this.btnCreateOU.Location = new System.Drawing.Point(222, 153);
            this.btnCreateOU.Name = "btnCreateOU";
            this.btnCreateOU.Size = new System.Drawing.Size(75, 23);
            this.btnCreateOU.TabIndex = 3;
            this.btnCreateOU.Text = "Kaydet";
            this.btnCreateOU.Click += new System.EventHandler(this.btnCreateOU_Click);
            // 
            // txtDescpriction
            // 
            this.txtDescpriction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDescpriction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescpriction.ForeColor = System.Drawing.Color.White;
            this.txtDescpriction.Location = new System.Drawing.Point(78, 102);
            this.txtDescpriction.Multiline = true;
            this.txtDescpriction.Name = "txtDescpriction";
            this.txtDescpriction.Size = new System.Drawing.Size(219, 45);
            this.txtDescpriction.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // txtOUName
            // 
            this.txtOUName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtOUName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOUName.ForeColor = System.Drawing.Color.White;
            this.txtOUName.Location = new System.Drawing.Point(78, 72);
            this.txtOUName.Name = "txtOUName";
            this.txtOUName.Size = new System.Drawing.Size(219, 20);
            this.txtOUName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Üst OU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni OU:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 43);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "OU Oluştur";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.Location = new System.Drawing.Point(301, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            toolTipTitleItem4.Text = "Uygulamayı Kapat";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Uygulamadan çıkmak için kullanınız";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.btnClose.SuperTip = superToolTip4;
            this.btnClose.TabIndex = 15;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCreateOU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(341, 249);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateOU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateOU";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOU.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.TextBox txtDescpriction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOUName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCreateOU;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbOU;
        private System.Windows.Forms.Label label4;
    }
}