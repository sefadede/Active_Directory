using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class Users
    {
        public string GivenName { get; set; } //isim
        public string Surname { get; set; } //soyisim
        public string Name { get; set; } //AdiSoyadi
        public string DisplayName { get; set; } //adisoyadi
        public string SamAccountName { get; set; }//HesapAdi
        public string UserPrincipalName { get; set; }//HesapAdi2
        public string AccountPassword { get; set; }//Password
        public bool ChangePasswordAtLogon { get; set; }//false
        public bool PasswordNeverExpires { get; set; }//true
        public bool Enabled { get; set; }//true
        public string Path { get; set; }//OUName1
        public string Title { get; set; }//Unvan
        public string Department { get; set; }//Birim
        public string Company { get; set; }//Şirket
        public string OfficePhone { get; set; }//Dahili
        public string MobilePhone { get; set; }//GSM
        public string City { get; set; }//Şehir
        public string PostalCode { get; set; }//Posta Kodu
        public string State { get; set; }//Semt
        public string Despriction { get; set; }//Sicil no-Açıklama
        public string EmailAddress { get; set; }//Email
        public string EmployeNumber { get; set; }//Sicil No
        public string Status { get; set; }//Error
    }
}
