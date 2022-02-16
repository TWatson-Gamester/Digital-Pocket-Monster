using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class AccountInfo
    {
        [Required]
        public int ID { get; set; }
        [Required] [Column(TypeName = "varchar(15)")]
        public string firstName { get; set; }
        [Required] [Column(TypeName = "varchar(25)")]
        public string lastName { get; set; }
        [Required] [Column(TypeName = "varchar(50)")]
        public string username { get; set; }
        [Required] [Column(TypeName = "varchar(50)")]
        public string password { get; set; }
        [Required] [Column(TypeName = "varchar(100)")]
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