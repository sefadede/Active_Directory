using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemManagement.Models;

namespace SystemManagement.Controls
{
    [System.Runtime.InteropServices.Guid("F4711088-DAA7-46F6-9B37-15F4EF3EB73D")]
    public partial class frmLogin : Form
    {
        MainForm mainForm;
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.Focus();
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
        private void btnLogin_Click(object sender, EventArgs e)
        {

            ActiveDirectory ad = new ActiveDirectory();
            mainForm = new MainForm(ad);
            if (txtUserName.Text.Trim().Length>0&&txtPassword.Text.Trim().Length>0&&txtDomainName.Text.Trim().Length>0)
            {
                ad.UserName = txtUserName.Text;
                ad.Password = txtPassword.Text;
                ad.DomainName = txtDomainName.Text;
                if (ad.UserCheck())
                {
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    XtraMessageBox.Show("Kullanıcı adı yada şifrenizi kontrol ediniz", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Eksik bilgi var.\nLütfen bütün alanları doldurunuz", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
