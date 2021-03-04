namespace SystemManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new DevExpress.XtraEditors.SimpleButton();
            this.btnFullNormal = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimaze = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrganizationalUnit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateGroup = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnDomainUser = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlFormControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnFullNormal);
            this.panel1.Controls.Add(this.btnMinimaze);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 43);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Yönetim Paneli";
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHome.Location = new System.Drawing.Point(1202, 6);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(32, 32);
            toolTipTitleItem1.Text = "Anasayfa";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnHome.SuperTip = superToolTip1;
            this.btnHome.TabIndex = 20;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFullNormal
            // 
            this.btnFullNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullNormal.Appearance.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnFullNormal.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFullNormal.Appearance.Options.UseFont = true;
            this.btnFullNormal.Appearance.Options.UseForeColor = true;
            this.btnFullNormal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnFullNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullNormal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFullNormal.Location = new System.Drawing.Point(1282, 6);
            this.btnFullNormal.Margin = new System.Windows.Forms.Padding(4);
            this.btnFullNormal.Name = "btnFullNormal";
            this.btnFullNormal.Size = new System.Drawing.Size(32, 32);
            toolTipTitleItem2.Text = "Tam Ekran";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnFullNormal.SuperTip = superToolTip2;
            this.btnFullNormal.TabIndex = 18;
            this.btnFullNormal.Text = "2";
            this.btnFullNormal.Click += new System.EventHandler(this.btnFullNormal_Click);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimaze.Appearance.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMinimaze.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimaze.Appearance.Options.UseFont = true;
            this.btnMinimaze.Appearance.Options.UseForeColor = true;
            this.btnMinimaze.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimaze.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnMinimaze.Location = new System.Drawing.Point(1242, 6);
            this.btnMinimaze.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(32, 32);
            toolTipTitleItem3.Text = "Aşağı indir";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnMinimaze.SuperTip = superToolTip3;
            this.btnMinimaze.TabIndex = 17;
            this.btnMinimaze.Text = "0";
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.Location = new System.Drawing.Point(1322, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            toolTipTitleItem4.Text = "Uygulamayı Kapat";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Uygulamadan çıkmak için kullanınız";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem1);
            this.btnClose.SuperTip = superToolTip4;
            this.btnClose.TabIndex = 15;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnOrganizationalUnit);
            this.panel2.Controls.Add(this.btnCreateGroup);
            this.panel2.Controls.Add(this.btnAddUser);
            this.panel2.Controls.Add(this.btnDomainUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 641);
            this.panel2.TabIndex = 2;
            // 
            // btnOrganizationalUnit
            // 
            this.btnOrganizationalUnit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrganizationalUnit.Appearance.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnOrganizationalUnit.Appearance.Options.UseFont = true;
            this.btnOrganizationalUnit.Appearance.Options.UseForeColor = true;
            this.btnOrganizationalUnit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnOrganizationalUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrganizationalUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnOrganizationalUnit.Image")));
            this.btnOrganizationalUnit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnOrganizationalUnit.Location = new System.Drawing.Point(0, 213);
            this.btnOrganizationalUnit.Name = "btnOrganizationalUnit";
            this.btnOrganizationalUnit.Size = new System.Drawing.Size(323, 71);
            this.btnOrganizationalUnit.TabIndex = 8;
            this.btnOrganizationalUnit.Text = "Organizational Unit";
            this.btnOrganizationalUnit.Click += new System.EventHandler(this.btnOrganizationalUnit_Click);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateGroup.Appearance.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCreateGroup.Appearance.Options.UseFont = true;
            this.btnCreateGroup.Appearance.Options.UseForeColor = true;
            this.btnCreateGroup.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCreateGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateGroup.Image")));
            this.btnCreateGroup.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCreateGroup.Location = new System.Drawing.Point(0, 142);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(323, 71);
            this.btnCreateGroup.TabIndex = 7;
            this.btnCreateGroup.Text = "Grup Oluştur";
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddUser.Appearance.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddUser.Appearance.Options.UseFont = true;
            this.btnAddUser.Appearance.Options.UseForeColor = true;
            this.btnAddUser.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnAddUser.Location = new System.Drawing.Point(0, 71);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(323, 71);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Kullanıcı Ekle";
            this.btnAddUser.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDomainUser
            // 
            this.btnDomainUser.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDomainUser.Appearance.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnDomainUser.Appearance.Options.UseFont = true;
            this.btnDomainUser.Appearance.Options.UseForeColor = true;
            this.btnDomainUser.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDomainUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDomainUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDomainUser.Image")));
            this.btnDomainUser.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDomainUser.Location = new System.Drawing.Point(0, 0);
            this.btnDomainUser.Name = "btnDomainUser";
            this.btnDomainUser.Size = new System.Drawing.Size(323, 71);
            this.btnDomainUser.TabIndex = 5;
            this.btnDomainUser.Text = "Domain Kullanıcıları";
            this.btnDomainUser.Click += new System.EventHandler(this.btnDomainUser_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 684);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1367, 42);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1367, 641);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.pnlFormControl);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1367, 641);
            this.panel5.TabIndex = 3;
            // 
            // pnlFormControl
            // 
            this.pnlFormControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFormControl.BackgroundImage")));
            this.pnlFormControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFormControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormControl.Location = new System.Drawing.Point(323, 0);
            this.pnlFormControl.Name = "pnlFormControl";
            this.pnlFormControl.Size = new System.Drawing.Size(1044, 641);
            this.pnlFormControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1367, 726);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnHome;
        private DevExpress.XtraEditors.SimpleButton btnFullNormal;
        private DevExpress.XtraEditors.SimpleButton btnMinimaze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnAddUser;
        private DevExpress.XtraEditors.SimpleButton btnDomainUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlFormControl;
        private DevExpress.XtraEditors.SimpleButton btnOrganizationalUnit;
        private DevExpress.XtraEditors.SimpleButton btnCreateGroup;
    }
}

