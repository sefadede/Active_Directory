namespace SystemManagement.Models
{
    partial class frmUserDomain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDomain));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.gmDomain = new DevExpress.XtraGrid.GridControl();
            this.domainUserInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grDomain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grUserNAme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grespriction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grEmployee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grUserPrincipalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grSamAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grLastLogon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllGroup = new DevExpress.XtraEditors.SimpleButton();
            this.btnGroupQuery = new DevExpress.XtraEditors.SimpleButton();
            this.cmbGroupName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcelImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnPDFImport = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gmDomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainUserInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDomain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupName.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmDomain
            // 
            this.gmDomain.DataSource = this.domainUserInfoBindingSource;
            this.gmDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmDomain.Location = new System.Drawing.Point(0, 0);
            this.gmDomain.MainView = this.grDomain;
            this.gmDomain.Name = "gmDomain";
            this.gmDomain.Size = new System.Drawing.Size(1133, 582);
            this.gmDomain.TabIndex = 0;
            this.gmDomain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grDomain});
            // 
            // domainUserInfoBindingSource
            // 
            this.domainUserInfoBindingSource.DataSource = typeof(SystemManagement.Models.DomainUserInfo);
            // 
            // grDomain
            // 
            this.grDomain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grUserNAme,
            this.grespriction,
            this.grCN,
            this.grEmail,
            this.grEmployee_id,
            this.grUserPrincipalName,
            this.grSamAccountName,
            this.grLastLogon,
            this.grEnabled,
            this.gridColumn1});
            this.grDomain.GridControl = this.gmDomain;
            this.grDomain.Name = "grDomain";
            this.grDomain.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grDomain.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.grDomain.OptionsBehavior.ReadOnly = true;
            this.grDomain.OptionsView.RowAutoHeight = true;
            this.grDomain.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grDomain_RowCellStyle);
            // 
            // grUserNAme
            // 
            this.grUserNAme.Caption = "Ad Soyad";
            this.grUserNAme.FieldName = "display_name";
            this.grUserNAme.Name = "grUserNAme";
            this.grUserNAme.Visible = true;
            this.grUserNAme.VisibleIndex = 2;
            // 
            // grespriction
            // 
            this.grespriction.Caption = "Personel ID";
            this.grespriction.FieldName = "despriction";
            this.grespriction.Name = "grespriction";
            this.grespriction.Visible = true;
            this.grespriction.VisibleIndex = 0;
            // 
            // grCN
            // 
            this.grCN.Caption = "CN";
            this.grCN.FieldName = "distingguished_name";
            this.grCN.Name = "grCN";
            this.grCN.Visible = true;
            this.grCN.VisibleIndex = 3;
            // 
            // grEmail
            // 
            this.grEmail.Caption = "E-Mail Adres";
            this.grEmail.FieldName = "email_adress";
            this.grEmail.Name = "grEmail";
            this.grEmail.Visible = true;
            this.grEmail.VisibleIndex = 4;
            // 
            // grEmployee_id
            // 
            this.grEmployee_id.Caption = "Employe ID";
            this.grEmployee_id.FieldName = "employee_id";
            this.grEmployee_id.Name = "grEmployee_id";
            this.grEmployee_id.Visible = true;
            this.grEmployee_id.VisibleIndex = 1;
            // 
            // grUserPrincipalName
            // 
            this.grUserPrincipalName.Caption = "Ana Kullanıcı Adı";
            this.grUserPrincipalName.FieldName = "user_principal_name";
            this.grUserPrincipalName.Name = "grUserPrincipalName";
            this.grUserPrincipalName.Visible = true;
            this.grUserPrincipalName.VisibleIndex = 5;
            // 
            // grSamAccountName
            // 
            this.grSamAccountName.Caption = "Sam Hesap Adı";
            this.grSamAccountName.FieldName = "sam_account_name";
            this.grSamAccountName.Name = "grSamAccountName";
            this.grSamAccountName.Visible = true;
            this.grSamAccountName.VisibleIndex = 6;
            // 
            // grLastLogon
            // 
            this.grLastLogon.Caption = "Son Giriş Tarihi";
            this.grLastLogon.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.grLastLogon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grLastLogon.FieldName = "last_logon";
            this.grLastLogon.Name = "grLastLogon";
            this.grLastLogon.Visible = true;
            this.grLastLogon.VisibleIndex = 7;
            // 
            // grEnabled
            // 
            this.grEnabled.Caption = "Aktif?";
            this.grEnabled.FieldName = "enabled";
            this.grEnabled.Name = "grEnabled";
            this.grEnabled.Visible = true;
            this.grEnabled.VisibleIndex = 9;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Son Çıkış Tarihi";
            this.gridColumn1.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "last_logoff";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAllGroup);
            this.panel1.Controls.Add(this.btnGroupQuery);
            this.panel1.Controls.Add(this.cmbGroupName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExcelImport);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnPDFImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnAllGroup
            // 
            this.btnAllGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnAllGroup.Image")));
            this.btnAllGroup.Location = new System.Drawing.Point(301, 37);
            this.btnAllGroup.Name = "btnAllGroup";
            this.btnAllGroup.Size = new System.Drawing.Size(113, 23);
            this.btnAllGroup.TabIndex = 97;
            this.btnAllGroup.Text = "Tüm Liste Getir";
            this.btnAllGroup.Click += new System.EventHandler(this.btnAllGroup_Click);
            // 
            // btnGroupQuery
            // 
            this.btnGroupQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupQuery.Image")));
            this.btnGroupQuery.Location = new System.Drawing.Point(301, 8);
            this.btnGroupQuery.Name = "btnGroupQuery";
            this.btnGroupQuery.Size = new System.Drawing.Size(113, 23);
            this.btnGroupQuery.TabIndex = 96;
            this.btnGroupQuery.Text = "Grup Listesi Getir";
            this.btnGroupQuery.Click += new System.EventHandler(this.btnGroupQuery_Click);
            // 
            // cmbGroupName
            // 
            this.cmbGroupName.Location = new System.Drawing.Point(89, 23);
            this.cmbGroupName.Name = "cmbGroupName";
            this.cmbGroupName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGroupName.Size = new System.Drawing.Size(202, 20);
            this.cmbGroupName.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "Grup Adı";
            // 
            // btnExcelImport
            // 
            this.btnExcelImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelImport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExcelImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelImport.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelImport.Image")));
            this.btnExcelImport.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExcelImport.Location = new System.Drawing.Point(1084, 19);
            this.btnExcelImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcelImport.Name = "btnExcelImport";
            this.btnExcelImport.Size = new System.Drawing.Size(32, 32);
            toolTipTitleItem1.Text = "Excel Olarak Aktar";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnExcelImport.SuperTip = superToolTip1;
            this.btnExcelImport.TabIndex = 91;
            this.btnExcelImport.Click += new System.EventHandler(this.btnExcelImport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrint.Location = new System.Drawing.Point(1004, 19);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 32);
            toolTipTitleItem2.Text = "Yazdır";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnPrint.SuperTip = superToolTip2;
            this.btnPrint.TabIndex = 93;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPDFImport
            // 
            this.btnPDFImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDFImport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPDFImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDFImport.Image = ((System.Drawing.Image)(resources.GetObject("btnPDFImport.Image")));
            this.btnPDFImport.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPDFImport.Location = new System.Drawing.Point(1044, 19);
            this.btnPDFImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDFImport.Name = "btnPDFImport";
            this.btnPDFImport.Size = new System.Drawing.Size(32, 32);
            toolTipTitleItem3.Text = "Pdf Olarak Aktar";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnPDFImport.SuperTip = superToolTip3;
            this.btnPDFImport.TabIndex = 92;
            this.btnPDFImport.Click += new System.EventHandler(this.btnPDFImport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gmDomain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 582);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.44674F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.55326F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 664);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmUserDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmUserDomain";
            this.Size = new System.Drawing.Size(1139, 664);
            ((System.ComponentModel.ISupportInitialize)(this.gmDomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainUserInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDomain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupName.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gmDomain;
        private DevExpress.XtraGrid.Views.Grid.GridView grDomain;
        private DevExpress.XtraGrid.Columns.GridColumn grUserNAme;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnExcelImport;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnPDFImport;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGroupName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnAllGroup;
        private DevExpress.XtraEditors.SimpleButton btnGroupQuery;
        private DevExpress.XtraGrid.Columns.GridColumn grespriction;
        private DevExpress.XtraGrid.Columns.GridColumn grCN;
        private DevExpress.XtraGrid.Columns.GridColumn grEmail;
        private DevExpress.XtraGrid.Columns.GridColumn grEmployee_id;
        private DevExpress.XtraGrid.Columns.GridColumn grUserPrincipalName;
        private DevExpress.XtraGrid.Columns.GridColumn grSamAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn grLastLogon;
        private System.Windows.Forms.BindingSource domainUserInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn grEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
