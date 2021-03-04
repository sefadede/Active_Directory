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

namespace SystemManagement.Controls
{
    public partial class frmAddUser : UserControl
    {
        public frmAddUser()
        {
            InitializeComponent();
            //AddSingleUser();
        }
        private void AddSingleUser()
        {
            //try
            //{
            //    string stringDomainName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            //    PrincipalContext PrincipalContext4 = new PrincipalContext(ContextType.Domain, stringDomainName, textboxOu.Text, ContextOptions.SimpleBind, "sefa.dede", "Sd123456");
            //    UserPrincipal UserPrincipal1 = new UserPrincipal(PrincipalContext4, textboxLonOnName.Text, passwordboxUserPass.Password, true);

            //    UserPrincipal1.UserPrincipalName = textboxSamAccountName.Text;
            //    UserPrincipal1.Name = textboxName.Text;
            //    UserPrincipal1.GivenName = textboxGivenName.Text;
            //    UserPrincipal1.Surname = textboxSurname.Text;
            //    UserPrincipal1.DisplayName = textboxDisplayName.Text;
            //    UserPrincipal1.Description = textboxDescription.Text;
            //    if (radiobuttonEnable.IsChecked == true)
            //    {
            //        UserPrincipal1.Enabled = true;
            //    }
            //    else
            //    {
            //        UserPrincipal1.Enabled = false;
            //    }
            //    UserPrincipal1.Save();
            //    MessageBox.Show("Saved Sucessfully");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            string domainName = "hstn.local";
            var pc = new PrincipalContext(ContextType.Domain, domainName, "sefa.dede", "Sd123456");

            GroupPrincipal group = GroupPrincipal.FindByIdentity(pc, "Sefadeneme_GRP");
            using (var up = new UserPrincipal(pc))
            {
                up.DisplayName = "sefa çorlu";
                up.SamAccountName = "sefa.corlu";
                up.EmailAddress = "deneme email";
                up.SetPassword("Sd147852369");
                up.Enabled = true;

                up.ExpirePasswordNow();
                up.Save();
            }
        }
        public static void AddUser_2()
        {
            //UserControl
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {

        }
    }
}
