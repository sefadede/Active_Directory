using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemManagement.Models
{
    public partial class frmControlPanel : UserControl
    {
        MainForm mainform;
        frmDomainList domainList;
        public frmControlPanel(MainForm myForm)
        {
            this.mainform = myForm;
            InitializeComponent();
        }

        private void btnDomainUser_Click(object sender, EventArgs e)
        {
            domainList = new frmDomainList();
            mainform.pnlFormControl.Controls.Clear();

            mainform.pnlFormControl.SuspendLayout();
            mainform.pnlFormControl.Controls.Clear();
            mainform.pnlFormControl.Controls.Add(domainList);
            mainform.pnlFormControl.Dock = DockStyle.Fill;

            mainform.pnlFormControl.ResumeLayout();
        }
    }
}
