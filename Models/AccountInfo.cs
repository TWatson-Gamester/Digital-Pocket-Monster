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
        public string FirstName { get; set; }
        [Required] [Column(TypeName = "varchar(25)")]
        public string LastName { get; set; }
        [Required] [Column(TypeName = "varchar(50)")]
        public string Username { get; set; }
        [Required] [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }
        [Required] [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        public AccountInfo() { }

        public AccountInfo(int id, string firstName, string lastname, string username, string password, string email)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Username = username;
            this.Password = password;
            this.Email = email; 
        }
    }
}