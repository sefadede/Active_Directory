using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class DomainUserInfo
    {
        public string display_name { get; set; }
        public string despriction { get; set; }
        public string distingguished_name { get; set; }
        public string email_adress { get; set; }
        public int employee_id { get; set; }
        public string user_principal_name { get; set; }
        public string sam_account_name { get; set; }
        public DateTime last_logon { get; set; }
        public DateTime last_logoff { get; set; }
        public bool enabled { get; set; }
    }
}
