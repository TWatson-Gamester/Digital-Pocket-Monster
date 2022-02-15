using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class AccountInfo
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public AccountInfo() { }

        public AccountInfo(int id, string firstName, string lastname, string username, string password, string email)
        {
            this.ID = id;
            this.firstName = firstName;
            this.lastName = lastname;
            this.username = username;
            this.password = password;
            this.email = email; 
        }
    }
}