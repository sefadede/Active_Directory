using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemManagement.Models;

namespace SystemManagement.Controls
{
    public partial class frmOUList : Form
    {
        ActiveDirectory activeDirectory;
        public frmOUList(ActiveDirectory AD)
        {
            this.activeDirectory = AD;
            InitializeComponent();
            GetOUList();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetOU_Click(object sender, EventArgs e)
        {
            GetOUList();
        }
        List<string> OULIST = new List<string>();
        private void GetOUList()
        {
            OrganizationalUnit ou = new OrganizationalUnit();
            organizationalUnitBindingSource.Clear();
            OULIST = activeDirectory.GetOUList();
            foreach (var item in OULIST)
            {
                ou.ldap = item;
                organizationalUnitBindingSource.Add(ou);
                ou = new OrganizationalUnit();
            }
        }
        private void btnAddOU_Click(object sender, EventArgs e)
        {
            frmCreateOU createOU = new frmCreateOU(activeDirectory, OULIST);
            createOU.ShowDialog();
        }
    }
}
