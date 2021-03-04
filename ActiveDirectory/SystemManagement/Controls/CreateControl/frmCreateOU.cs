using DevExpress.XtraEditors;
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
    public partial class frmCreateOU : Form
    {
        OrganizationalUnit ou;
        ActiveDirectory activeDirectory;
        List<string> ouList = new List<string>();
        public frmCreateOU(ActiveDirectory AD, List<string> ous)
        {
            this.ouList = ous;
            this.activeDirectory = AD;
            InitializeComponent();
            InsertOU();
            txtOUName.Focus();
        }
        private void InsertOU()
        {
            cmbOU.Properties.Items.Clear();
            foreach (var item in ouList)
            {
                cmbOU.Properties.Items.Add(item);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnCreateOU_Click(object sender, EventArgs e)
        {
            ou = new OrganizationalUnit();
            if (txtOUName.Text.Trim().Length > 0)
            {
                if (cmbOU.SelectedIndex == -1)
                {
                    ou.ouName = txtOUName.Text;
                    ou.ouDescription = txtDescpriction.Text;
                    var info = activeDirectory.CreateOU(ou).errName;
                    XtraMessageBox.Show(info, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOUName.Clear();
                    txtDescpriction.Clear();
                }
                else
                {
                    DialogResult result = XtraMessageBox.Show(cmbOU.SelectedText + "\nAlt OU olarak oluşturulacaktır.\nDevam etmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ou.mainOuName = cmbOU.SelectedText;
                        ou.ouName = txtOUName.Text;
                        ou.ouDescription = txtDescpriction.Text;
                        var info = activeDirectory.CreateOUinOU(ou).errName;
                        XtraMessageBox.Show(info, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtOUName.Clear();
                        txtDescpriction.Clear();
                    }
                    else
                    {

                    }
                }

            }
        }

        private void cmbOU_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOUName.Text = cmbOU.SelectedText;
        }
    }
}
