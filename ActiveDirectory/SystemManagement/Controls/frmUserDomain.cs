using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using DevExpress.Utils.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace SystemManagement.Models
{
    public partial class frmUserDomain : UserControl
    {
        ActiveDirectory ad;
        public frmUserDomain(ActiveDirectory active)
        {
            this.ad = active;
            InitializeComponent();
            GetGroups();
        }
        private void GetGroups()
        {
            cmbGroupName.Properties.Items.Clear();
            foreach (string s in ad.GetGroups())
            {
                cmbGroupName.Properties.Items.Add(s);
            }
        }
        private void btnExcelImport_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportToExcel = new SaveFileDialog();
            exportToExcel.Title = "Excel Dosyası Oluştur";
            exportToExcel.Filter = "Excel Dosyasi(*.xls)|*.xls";
            exportToExcel.DefaultExt = "xls";
            if (exportToExcel.ShowDialog() == DialogResult.OK)
                grDomain.ExportToXls(exportToExcel.FileName);
        }

        private void btnPDFImport_Click(object sender, EventArgs e)
        {
            grDomain.ShowPrintPreview();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            grDomain.Print();
        }

        private void btnGroupQuery_Click(object sender, EventArgs e)
        {
            GetGroupUser();
        }
        private void btnAllGroup_Click(object sender, EventArgs e)
        {
            GetFullUser();
        }
        private void GetGroupUser()
        {
            try
            {
                string groupName = cmbGroupName.SelectedText;
                domainUserInfoBindingSource.Clear();
                foreach (var item in ad.GetGroupToUser(groupName))
                {
                    domainUserInfoBindingSource.Add(item);
                }
                Console.WriteLine("\nWe did not find that group in that domain, perhaps the group resides in a different domain?");
                Console.ReadLine();
                
            }
            catch (ArgumentException)
            {

            }
        }
        int maxUserCount = 0;
        private void GetFullUser()
        {
            domainUserInfoBindingSource.Clear();
            foreach (var item in ad.GetFullUser())
            {
                maxUserCount++;
                domainUserInfoBindingSource.Add(item);
            }
            XtraMessageBox.Show("Toplam: "+maxUserCount+" Kullanıcı Bulundu","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void grDomain_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column.FieldName == "enabled")
            {
                if (currentView.GetRowCellDisplayText(e.RowHandle, currentView.Columns[8]) != "Checked")
                {
                    e.Appearance.BackColor = Color.Red;
                }
            }
        }
    }
}

