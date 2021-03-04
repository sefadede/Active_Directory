using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemManagement.Controls;
using SystemManagement.Models;

namespace SystemManagement
{
    public partial class MainForm : Form
    {
        public Size frmX { get; set; }
        public Size frmY { get; set; }
        frmAddUser addUser;
        ActiveDirectory activeD;
        frmUserDomain domainList;

        public MainForm(ActiveDirectory ad)
        {
            this.activeD = ad;
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlFormControl.Controls.Clear();
        }

        private void btnFullNormal_Click(object sender, EventArgs e)
        {
            FormWindowState bb = this.WindowState;
            if (bb == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnFullNormal.Text = "1";
            }
            else if (bb == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnFullNormal.Text = "2";
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnDomainUser_Click(object sender, EventArgs e)
        {
            pnlFormControl.SuspendLayout();
            pnlFormControl.Controls.Clear();
            domainList = new frmUserDomain(activeD);

            domainList.Dock = DockStyle.Fill;
            pnlFormControl.Controls.Add(domainList);
            pnlFormControl.ResumeLayout();

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            pnlFormControl.SuspendLayout();
            pnlFormControl.Controls.Clear();
            addUser = new frmAddUser();
            addUser.Dock = DockStyle.Fill;
            pnlFormControl.Controls.Add(addUser);
            pnlFormControl.ResumeLayout();
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            frmCreateGroup createGroup = new frmCreateGroup(activeD);
            createGroup.ShowDialog();
        }

        private void btnOrganizationalUnit_Click(object sender, EventArgs e)
        {
            frmOUList ouList = new frmOUList(activeD);
            ouList.ShowDialog();
        }
    }
}
