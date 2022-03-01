using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class UserIDToCards : IdentityUser
    {
        public int CardID { get; set; }

        public int UserID { get; set; }
    }
}
