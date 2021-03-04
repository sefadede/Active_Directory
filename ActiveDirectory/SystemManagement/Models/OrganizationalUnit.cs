using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class OrganizationalUnit
    {
        public string mainOuName { get; set; }
        public string ouName { get; set; }
        public string ouDescription { get; set; }
        public string errName { get; set; }
        public string ldap { get; set; }
    }
}
