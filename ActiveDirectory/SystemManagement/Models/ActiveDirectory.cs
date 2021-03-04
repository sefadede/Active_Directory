using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace SystemManagement.Models
{
    public class ActiveDirectory
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DomainName { get; set; }

        public bool UserCheck()
        {
            using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain, DomainName, UserName, Password))
            {
                bool isValid = ctx.ValidateCredentials(UserName, Password);
                return isValid;
            }
        }
        public List<string> GetGroups()
        {
            List<string> groups = new List<string>();
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain, DomainName, UserName, Password);
            GroupPrincipal grp = new GroupPrincipal(ctx);
            PrincipalSearcher srch = new PrincipalSearcher(grp);
            foreach (var found in srch.FindAll())
            {
                groups.Add(found.Name);
            }
            return groups;
        }
        public List<DomainUserInfo> GetFullUser()
        {
            List<DomainUserInfo> userList = new List<DomainUserInfo>();
            try
            {
                int count = 0;
                using (var context = new PrincipalContext(ContextType.Domain, DomainName, UserName, Password))
                {
                    using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                    {
                        DomainUserInfo userInfo = new DomainUserInfo();
                        foreach (var result in searcher.FindAll())
                        {
                            DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                            userInfo.display_name = (string)de.Properties["displayname"].Value;
                            userInfo.despriction = result.Description;
                            userInfo.distingguished_name = (string)de.Properties["distinguishedname"].Value;
                            userInfo.user_principal_name = (string)de.Properties["userprincipalname"].Value;
                            userInfo.sam_account_name = (string)de.Properties["samaccountname"].Value;
                            try
                            {
                                int flags = (int)de.Properties["userAccountControl"].Value;
                                userInfo.enabled = !Convert.ToBoolean(flags & 0x0002);
                            }
                            catch (ArgumentException)
                            {
                            }
                            try
                            {
                                if ((de.Properties["mail"][0]) != null)
                                    userInfo.email_adress = de.Properties["mail"][0].ToString();
                            }
                            catch (ArgumentException)
                            {
                            }
                            userList.Add(userInfo);
                            userInfo = new DomainUserInfo();
                            Console.WriteLine();
                        }

                    }
                    Console.WriteLine(count.ToString());
                }

            }
            catch (ArgumentException)
            {

            }
            catch (NullReferenceException)
            {

            }
            return userList;
        }
        public string AddSingleUser(Users user)
        {
            string status = "";

            PrincipalContext ctx = new PrincipalContext(ContextType.Domain, DomainName, user.Path, UserName, Password);
            UserPrincipal userP = new UserPrincipal(ctx,user.SamAccountName, user.AccountPassword, true);
            userP.GivenName = user.GivenName;
            userP.Name = user.Name;
            userP.Surname = user.Surname;
            userP.DisplayName = user.DisplayName;
            //userP.SamAccountName = user.SamAccountName;
            userP.UserPrincipalName = user.UserPrincipalName;
            userP.Description = user.Despriction;
            userP.EmailAddress = user.EmailAddress;


            return status;
        }
        public List<DomainUserInfo> GetGroupToUser(string groupName)
        {
            List<DomainUserInfo> userList = new List<DomainUserInfo>();
            try
            {
                PrincipalContext ctx = new PrincipalContext(ContextType.Domain, DomainName, UserName, Password);
                GroupPrincipal grp = GroupPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, groupName);
                if (grp != null)
                {
                    DomainUserInfo userInfo = new DomainUserInfo();
                    foreach (Principal p in grp.GetMembers(false))
                    {
                        SearchResult result = null;
                        using (var user = UserPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, p.SamAccountName))
                        {
                            using (DirectoryEntry deUser = user.GetUnderlyingObject() as DirectoryEntry)
                            {
                                using (DirectorySearcher deUserContainer = new DirectorySearcher(deUser))
                                {
                                    SearchResultCollection results = deUserContainer.FindAll();
                                    result = (results.Count != 0) ? results[0] : null;

                                    try
                                    {

                                        userInfo.display_name = result.Properties["displayname"][0].ToString();
                                        if (p.Description != null) userInfo.despriction = p.Description;
                                        userInfo.distingguished_name = result.Properties["distinguishedname"][0].ToString();
                                        userInfo.user_principal_name = result.Properties["userprincipalname"][0].ToString();
                                        userInfo.sam_account_name = result.Properties["samaccountname"][0].ToString();
                                        int flags = (int)deUser.Properties["userAccountControl"].Value;
                                        userInfo.enabled = !Convert.ToBoolean(flags & 0x0002);

                                        long lastlg = (long)(result.Properties["lastlogon"][0]);
                                        userInfo.last_logon = DateTime.FromFileTime(lastlg);

                                        if ((result.Properties["mail"][0]) != null)
                                            userInfo.email_adress = result.Properties["mail"][0].ToString();

                                    }
                                    catch (ArgumentOutOfRangeException ex)
                                    {

                                    }
                                    userList.Add(userInfo);
                                    userInfo = new DomainUserInfo();
                                }
                            }
                        }
                    }

                    grp.Dispose();
                    ctx.Dispose();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nWe did not find that group in that domain, perhaps the group resides in a different domain?");
                    Console.ReadLine();
                }
                Console.ReadLine();
            }
            catch (ArgumentException)
            {

            }
            catch (NullReferenceException)
            {

            }
            return userList;
        }
        public OrganizationalUnit CreateOUinOU(OrganizationalUnit ou)
        {
            try
            {
                string strPath = "OU=FINANS_1,OU=FINANS,DC=HSTN,DC=LOCAL";
                ou.ouName = ou.ouName.Replace("LDAP://hstn.local/", "");
                // get just DC portion of distinguished name
                int dcIndex = strPath.IndexOf("DC=");
                string dcSubString = strPath.Substring(dcIndex);
                // get just OU portion of distinguished name
                string ouSubString = strPath.Substring(0, dcIndex - 1);
                string tempDistinguishedName = dcSubString;
                string[] ouSubStrings = ouSubString.Split(',');
                for (int i = ouSubStrings.Length - 1; i >= 0; i--)
                {
                    // bind
                    DirectoryEntry parentEntry = new DirectoryEntry(ou.mainOuName, UserName, Password);
                    // Create OU
                    DirectoryEntry newOU = parentEntry.Children.Add(ouSubStrings[i], "OrganizationalUnit");
                    newOU.CommitChanges();
                    // create distinguishedName for next bind        
                    tempDistinguishedName = ouSubStrings[i] + "," + tempDistinguishedName;
                    // clean up unmanaged resources
                    newOU.Dispose();
                    parentEntry.Dispose();
                    ou.errName = "OU Başarıyla Oluşturuldu";

                }
            }
            catch (Exception ex)
            {
                ou.errName = ex.Message;
            }
            return ou;

        }
        public OrganizationalUnit CreateOU(OrganizationalUnit OU)
        {
            OrganizationalUnit oUnit = new OrganizationalUnit();
            DirectoryEntry objADAM;  // Binding object.
            DirectoryEntry objOU;  // Organizational unit.
            string strDescription;   // Description of OU.
            string strOU;
            string strPath;          // Binding path.
                                     // Construct the binding string.
            strPath = "LDAP://10.21.42.2:389/O=Fabrikam,C=US";

            Console.WriteLine("Bind to: {0}", strPath);
            // Get AD LDS object.
            try
            {
                objADAM = new DirectoryEntry("LDAP://hstn.local", UserName, Password);
                objADAM.RefreshCache();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:   Bind failed.");
                Console.WriteLine("         {0}", e.Message);
                oUnit.errName = e.Message;
                return oUnit;
            }

            // Specify Organizational Unit.
            strOU = "OU=" + OU.ouName;
            strDescription = OU.ouDescription;
            Console.WriteLine("Create:  {0}", strOU);

            // Create Organizational Unit.
            try
            {
                objOU = objADAM.Children.Add(strOU,
                    "OrganizationalUnit");
                objOU.Properties["description"].Add(strDescription);
                objOU.CommitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:   Create failed.");
                Console.WriteLine("         {0}", e.Message);
                oUnit.errName = e.Message;
                return oUnit;
            }

            // Output Organizational Unit attributes.
            Console.WriteLine("Success: Create succeeded.");
            Console.WriteLine("Name:    {0}", objOU.Name);
            Console.WriteLine("         {0}",
                objOU.Properties["description"].Value);
            objOU.Properties["ProtectedFromAccidentalDeletion"].Value = false;
            oUnit.errName = "OU Başarıyla Oluşturuldu";
            return oUnit;

        }
        public List<string> GetOUList()
        {
            List<string> orgUnits = new List<string>();

            DirectoryEntry startingPoint = new DirectoryEntry("LDAP://hstn.local", UserName, Password);

            DirectorySearcher searcher = new DirectorySearcher(startingPoint);
            searcher.Filter = "(objectCategory=organizationalUnit)";

            foreach (SearchResult res in searcher.FindAll())
            {
                orgUnits.Add(res.Path);
            }
            return orgUnits;
        }
    }
}
