namespace SystemManagement.Controls
{
    partial class frmOUList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOUList));
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gmOU = new DevExpress.XtraGrid.GridControl();
            this.organizationalUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grOU = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grLdap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddOU = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetOU = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gmOU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationalUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grOU)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 43);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "OU Listesi";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.Location = new System.Drawing.Point(361, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            toolTipTitleItem3.Text = "Uygulamayı Kapat";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Uygulamadan çıkmak için kullanınız";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnClose.SuperTip = superToolTip3;
            this.btnClose.TabIndex = 15;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 407);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gmOU);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 358);
            this.panel4.TabIndex = 1;
            // 
            // gmOU
            // 
            this.gmOU.DataSource = this.organizationalUnitBindingSource;
            this.gmOU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmOU.Location = new System.Drawing.Point(0, 0);
            this.gmOU.MainView = this.grOU;
            this.gmOU.Name = "gmOU";
            this.gmOU.Size = new System.Drawing.Size(406, 358);
            this.gmOU.TabIndex = 1;
            this.gmOU.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grOU});
            // 
            // organizationalUnitBindingSource
            // 
            this.organizationalUnitBindingSource.DataSource = typeof(SystemManagement.Models.OrganizationalUnit);
            // 
            // grOU
            // 
            this.grOU.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grLdap});
            this.grOU.GridControl = this.gmOU;
            this.grOU.Name = "grOU";
            this.grOU.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grOU.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.grOU.OptionsBehavior.ReadOnly = true;
            this.grOU.OptionsView.RowAutoHeight = true;
            // 
            // grLdap
            // 
            this.grLdap.Caption = "LDAP";
            this.grLdap.FieldName = "ldap";
            this.grLdap.Name = "grLdap";
            this.grLdap.Visible = true;
            this.grLdap.VisibleIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddOU);
            this.panel3.Controls.Add(this.btnGetOU);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 49);
            this.panel3.TabIndex = 0;
            // 
            // btnAddOU
            // 
            this.btnAddOU.Location = new System.Drawing.Point(95, 13);
            this.btnAddOU.Name = "btnAddOU";
            this.btnAddOU.Size = new System.Drawing.Size(75, 23);
            this.btnAddOU.TabIndex = 0;
            this.btnAddOU.Text = "OU Ekle";
            this.btnAddOU.Click += new System.EventHandler(this.btnAddOU_Click);
            // 
            // btnGetOU
            // 
            this.btnGetOU.Location = new System.Drawing.Point(14, 13);
            this.btnGetOU.Name = "btnGetOU";
            this.btnGetOU.Size = new System.Drawing.Size(75, 23);
            this.btnGetOU.TabIndex = 0;
            this.btnGetOU.Text = "OU Listele";
            this.btnGetOU.Click += new System.EventHandler(this.btnGetOU_Click);
            // 
            // frmOUList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOUList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOUList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gmOU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationalUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grOU)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnAddOU;
        private DevExpress.XtraEditors.SimpleButton btnGetOU;
        private DevExpress.XtraGrid.GridControl gmOU;
        private DevExpress.XtraGrid.Views.Grid.GridView grOU;
        private DevExpress.XtraGrid.Columns.GridColumn grLdap;
        private System.Windows.Forms.BindingSource organizationalUnitBindingSource;
    }
}