namespace SystemManagement.Controls
{
    partial class frmAddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.singleUser = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveUser = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSamAccountName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserPrincipalName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeID = new System.Windows.Forms.TextBox();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDespriction = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOfficePhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.multiUser = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.singleUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.multiUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabControl.Appearance.Options.UseBackColor = true;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.singleUser;
            this.tabControl.Size = new System.Drawing.Size(1161, 629);
            this.tabControl.TabIndex = 3;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.singleUser,
            this.multiUser});
            // 
            // singleUser
            // 
            this.singleUser.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.singleUser.Appearance.PageClient.Options.UseBackColor = true;
            this.singleUser.Controls.Add(this.panel1);
            this.singleUser.Image = ((System.Drawing.Image)(resources.GetObject("singleUser.Image")));
            this.singleUser.Name = "singleUser";
            this.singleUser.Size = new System.Drawing.Size(1155, 582);
            this.singleUser.Text = "Kullanıcı Ekle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSaveUser);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 582);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.Image")));
            this.btnSaveUser.Location = new System.Drawing.Point(989, 323);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(106, 33);
            this.btnSaveUser.TabIndex = 5;
            this.btnSaveUser.Text = "Kaydet";
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSamAccountName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtUserPrincipalName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtEmployeID);
            this.groupBox3.Controls.Add(this.txtAccountPassword);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtPath);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(767, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 255);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account";
            // 
            // txtSamAccountName
            // 
            this.txtSamAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSamAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSamAccountName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSamAccountName.ForeColor = System.Drawing.Color.White;
            this.txtSamAccountName.Location = new System.Drawing.Point(159, 24);
            this.txtSamAccountName.Name = "txtSamAccountName";
            this.txtSamAccountName.Size = new System.Drawing.Size(152, 22);
            this.txtSamAccountName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Principal Name";
            // 
            // txtUserPrincipalName
            // 
            this.txtUserPrincipalName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtUserPrincipalName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserPrincipalName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserPrincipalName.ForeColor = System.Drawing.Color.White;
            this.txtUserPrincipalName.Location = new System.Drawing.Point(159, 52);
            this.txtUserPrincipalName.Name = "txtUserPrincipalName";
            this.txtUserPrincipalName.Size = new System.Drawing.Size(152, 22);
            this.txtUserPrincipalName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "OU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Account Password ";
            // 
            // txtEmployeID
            // 
            this.txtEmployeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtEmployeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmployeID.ForeColor = System.Drawing.Color.White;
            this.txtEmployeID.Location = new System.Drawing.Point(159, 136);
            this.txtEmployeID.Name = "txtEmployeID";
            this.txtEmployeID.Size = new System.Drawing.Size(152, 22);
            this.txtEmployeID.TabIndex = 1;
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtAccountPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAccountPassword.ForeColor = System.Drawing.Color.White;
            this.txtAccountPassword.Location = new System.Drawing.Point(159, 80);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(152, 22);
            this.txtAccountPassword.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(24, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 14);
            this.label19.TabIndex = 0;
            this.label19.Text = "Employe ID";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.Location = new System.Drawing.Point(159, 108);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(152, 22);
            this.txtPath.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sam Account Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPostalCode);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDepartment);
            this.groupBox2.Controls.Add(this.txtState);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtCompany);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(397, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 255);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPostalCode.ForeColor = System.Drawing.Color.White;
            this.txtPostalCode.Location = new System.Drawing.Point(144, 164);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(152, 22);
            this.txtPostalCode.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(144, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(152, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartment.ForeColor = System.Drawing.Color.White;
            this.txtDepartment.Location = new System.Drawing.Point(144, 52);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(152, 22);
            this.txtDepartment.TabIndex = 1;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtState.ForeColor = System.Drawing.Color.White;
            this.txtState.Location = new System.Drawing.Point(144, 136);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(152, 22);
            this.txtState.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(29, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Company";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(29, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 14);
            this.label16.TabIndex = 0;
            this.label16.Text = "State";
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompany.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCompany.ForeColor = System.Drawing.Color.White;
            this.txtCompany.Location = new System.Drawing.Point(144, 80);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(152, 22);
            this.txtCompany.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(29, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(144, 108);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(152, 22);
            this.txtCity.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(29, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "Postal Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGivenName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtEmailAddress);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtDespriction);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDisplayName);
            this.groupBox1.Controls.Add(this.txtMobilePhone);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtOfficePhone);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(46, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Given Name";
            // 
            // txtGivenName
            // 
            this.txtGivenName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtGivenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGivenName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGivenName.ForeColor = System.Drawing.Color.White;
            this.txtGivenName.Location = new System.Drawing.Point(145, 24);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(152, 22);
            this.txtGivenName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(145, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmailAddress.ForeColor = System.Drawing.Color.White;
            this.txtEmailAddress.Location = new System.Drawing.Point(145, 220);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(152, 22);
            this.txtEmailAddress.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(28, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 14);
            this.label18.TabIndex = 0;
            this.label18.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(145, 80);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(152, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // txtDespriction
            // 
            this.txtDespriction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDespriction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDespriction.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDespriction.ForeColor = System.Drawing.Color.White;
            this.txtDespriction.Location = new System.Drawing.Point(145, 136);
            this.txtDespriction.Name = "txtDespriction";
            this.txtDespriction.Size = new System.Drawing.Size(152, 22);
            this.txtDespriction.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(28, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 0;
            this.label17.Text = "Despriction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Display Name";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDisplayName.ForeColor = System.Drawing.Color.White;
            this.txtDisplayName.Location = new System.Drawing.Point(145, 108);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(152, 22);
            this.txtDisplayName.TabIndex = 1;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtMobilePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobilePhone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMobilePhone.ForeColor = System.Drawing.Color.White;
            this.txtMobilePhone.Location = new System.Drawing.Point(145, 192);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(152, 22);
            this.txtMobilePhone.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(28, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "Office Phone";
            // 
            // txtOfficePhone
            // 
            this.txtOfficePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtOfficePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOfficePhone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOfficePhone.ForeColor = System.Drawing.Color.White;
            this.txtOfficePhone.Location = new System.Drawing.Point(145, 164);
            this.txtOfficePhone.Name = "txtOfficePhone";
            this.txtOfficePhone.Size = new System.Drawing.Size(152, 22);
            this.txtOfficePhone.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(28, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mobile Phone";
            // 
            // multiUser
            // 
            this.multiUser.Controls.Add(this.panel2);
            this.multiUser.Image = ((System.Drawing.Image)(resources.GetObject("multiUser.Image")));
            this.multiUser.Name = "multiUser";
            this.multiUser.Size = new System.Drawing.Size(1155, 582);
            this.multiUser.Text = "Toplu Kullanıcı Ekle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 582);
            this.panel2.TabIndex = 1;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tabControl);
            this.Name = "frmAddUser";
            this.Size = new System.Drawing.Size(1161, 629);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.singleUser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.multiUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage singleUser;
        private DevExpress.XtraTab.XtraTabPage multiUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserPrincipalName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSamAccountName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmployeID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDespriction;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOfficePhone;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton btnSaveUser;
    }
}
